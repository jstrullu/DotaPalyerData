using Flurl.Http.Testing;
using System.Net;
using DotaPlayerData.API;
using FluentAssertions;
using Flurl.Http;

[TestFixture]
public class OpenDotaApiClientTests
{
    private HttpTest _httpTest;
    private OpenDotaApiClient _openDotaApiClient;

    [SetUp]
    public void SetUp()
    {
        _httpTest = new HttpTest();
        _openDotaApiClient = new OpenDotaApiClient();
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
}