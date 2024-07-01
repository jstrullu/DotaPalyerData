using System.Net;
using DotaPlayerData.API.Configuration;
using DotaPlayerData.API.Impl;
using FluentAssertions;
using Flurl.Http;
using Flurl.Http.Testing;

namespace DotaPlayerData.Tests.API;

[TestFixture]
public class StratzApiTests
{
    private HttpTest _httpTest;
    private StratzApi _stratzApi;

    [SetUp]
    public void SetUp()
    {
        _httpTest = new HttpTest();
        _stratzApi = new StratzApi(new StratzConfiguration
        {
            BaseUrl = "https://api.stratz.com/api/v1/",
            ApiKey = "123456"
        });
    }
    
    [TearDown]
    public void TearDown()
    {
        _httpTest.Dispose();
    }

    [Test]
    public async Task GetPlayerinfo_WhenCalledWithCorrectData_ShouldRespondWithSuccess()
    {
        // Arrange
        const string expectedContent = "Mocked Player data";
        const int steamId = 123456;
        _httpTest.RespondWith(expectedContent, (int)HttpStatusCode.OK);

        // Act
        var result = await _stratzApi.GetPlayerInfos(steamId);

        // Assert
        result.Should().Be(expectedContent);
        _httpTest.ShouldHaveCalled($"https://api.stratz.com/api/v1/player/{steamId}")
        .WithVerb(HttpMethod.Get)
            .Times(1);
    }
    
    [Test]
    public void GetPlayerInfo_WithError_ShouldThrowError()
    {
        // Arrange
        _httpTest.RespondWith("Error", (int)HttpStatusCode.InternalServerError);
        const int steamId = 123456;

        // Act & Assert
        Assert.ThrowsAsync<FlurlHttpException>(async () =>
        {
            await _stratzApi.GetPlayerInfos(steamId);
        });
    }
    
    [Test]
    public async Task GetTeaminfo_WhenCalledWithCorrectData_ShouldRespondWithSuccess()
    {
        // Arrange
        const string expectedContent = "Mocked Team data";
        const int teamId = 123456;
        _httpTest.RespondWith(expectedContent, (int)HttpStatusCode.OK);

        // Act
        var result = await _stratzApi.GetTeamInfos(teamId);

        // Assert
        result.Should().Be(expectedContent);
        _httpTest.ShouldHaveCalled($"https://api.stratz.com/api/v1/team/{teamId}")
            .WithVerb(HttpMethod.Get)
            .Times(1);
    }
    
    [Test]
    public void GetTeamInfo_WithError_ShouldThrowError()
    {
        // Arrange
        _httpTest.RespondWith("Error", (int)HttpStatusCode.InternalServerError);
        const int teamId = 123456;

        // Act & Assert
        Assert.ThrowsAsync<FlurlHttpException>(async () =>
        {
            await _stratzApi.GetTeamInfos(teamId);
        });
    }
}