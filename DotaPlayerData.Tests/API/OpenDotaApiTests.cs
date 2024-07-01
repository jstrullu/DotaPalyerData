using System.Net;
using DotaPlayerData.API.Configuration;
using DotaPlayerData.API.Impl;
using FluentAssertions;
using Flurl.Http;
using Flurl.Http.Testing;

namespace DotaPlayerData.Tests.API;

[TestFixture]
public class OpenDotaApiClientTests
{
    private HttpTest _httpTest;
    private OpenDotaApiClient _openDotaApiClient;

    [SetUp]
    public void SetUp()
    {
        _httpTest = new HttpTest();
        _openDotaApiClient = new OpenDotaApiClient(new OpenDotaConfiguration
        {
            BaseUrl = "https://api.opendota.com/api/"
        });
    }

    [TearDown]
    public void TearDown()
    {
        _httpTest.Dispose();
    }

    [Test]
    public async Task GetAllDotaHeroes_ShouldReturnHeroes()
    {
        // Arrange
        string expectedContent = "Mocked heroes data";
        _httpTest.RespondWith(expectedContent, (int)HttpStatusCode.OK);

        // Act
        string result = await _openDotaApiClient.GetAllDotaHeroes();

        // Assert
        result.Should().Be(expectedContent);
        _httpTest.ShouldHaveCalled("https://api.opendota.com/api/heroes")
            .WithVerb(HttpMethod.Get)
            .Times(1);
    }

    [Test]
    public void GetAllDotaHeroes_WhenRequestFails_ShouldThrowException()
    {
        // Arrange
        _httpTest.RespondWith("Error", (int)HttpStatusCode.InternalServerError);

        // Act & Assert
        Assert.ThrowsAsync<FlurlHttpException>(async () =>
        {
            await _openDotaApiClient.GetAllDotaHeroes();
        });
    }

    [Test]
    public async Task GetPlayerMatches_ShouldReturnMatches()
    {
        string expectedContent = "Mocked Player Data";
        _httpTest.RespondWith(expectedContent, (int)HttpStatusCode.OK);
        long steamId = 123456;

        string result = await _openDotaApiClient.GetPlayerMatches(123456);

        result.Should().Be(expectedContent);
        _httpTest.ShouldHaveCalled($"https://api.opendota.com/api/players/{steamId}/matches")
            .WithVerb(HttpMethod.Get)
            .Times(1);
    }
    
    [Test]
    public void GetPlayerMatches_WhenRequestFails_ShouldThrowException()
    {
        // Arrange
        _httpTest.RespondWith("Error", (int)HttpStatusCode.InternalServerError);
        long steamId = 123456; 

        // Act & Assert
        Assert.ThrowsAsync<FlurlHttpException>(async () =>
        {
            await _openDotaApiClient.GetPlayerMatches(123456);
        });
    }
    
    [Test]
    public async Task SearchPlayer_ReturnsExpectedResult()
    {
        // Arrange
        string playerName = "testPlayer";
        string expectedResponse = "Player data";
        string baseUrl = "https://api.opendota.com";

        using (var httpTest = new HttpTest())
        {
            httpTest.RespondWith(expectedResponse);

            // Act
            string result = await _openDotaApiClient.SearchPlayer(playerName);

            // Assert
            result.Should().Be(expectedResponse);
            httpTest.ShouldHaveCalled($"{baseUrl}/api/search?q={playerName}")
                .WithVerb(HttpMethod.Get)
                .Times(1);
        }
    }

    [Test]
    public void SearchPlayer_ThrowsFlurlHttpException_OnHttpError()
    {
        // Arrange
        string playerName = "testPlayer";
        string baseUrl = "https://api.opendota.com";

        using (var httpTest = new HttpTest())
        {
            httpTest.RespondWith("Server error", 500);

            // Act & Assert
            Assert.ThrowsAsync<FlurlHttpException>(async () => await _openDotaApiClient.SearchPlayer(playerName));
            httpTest.ShouldHaveCalled($"{baseUrl}/api/search?q={playerName}")
                .WithVerb(HttpMethod.Get)
                .Times(1);
        }
    }
    
    [Test]
    public async Task GetPlayerInfos_ReturnsExpectedResult()
    {
        // Arrange
        const long steamId = 123456789;
        const string expectedResponse = "Player info data";
        const string baseUrl = "https://api.opendota.com";

        using var httpTest = new HttpTest();
        httpTest.RespondWith(expectedResponse);

        // Act
        var result = await _openDotaApiClient.GetPlayerInfos(steamId);

        // Assert
        result.Should().Be(expectedResponse);
        httpTest.ShouldHaveCalled($"{baseUrl}/api/players/{steamId}")
            .WithVerb(HttpMethod.Get)
            .Times(1);
    }

    [Test]
    public void GetPlayerInfos_ThrowsFlurlHttpException_OnHttpError()
    {
        // Arrange
        const long steamId = 123456789;
        const string baseUrl = "https://api.opendota.com";

        using var httpTest = new HttpTest();
        httpTest.RespondWith("Server error", 500);

        // Act & Assert
        Assert.ThrowsAsync<FlurlHttpException>( async () => await _openDotaApiClient.GetPlayerInfos(steamId));
        httpTest.ShouldHaveCalled($"{baseUrl}/api/players/{steamId}")
            .WithVerb(HttpMethod.Get)
            .Times(1);
    }
}