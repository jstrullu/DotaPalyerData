using System.Text.Json;
using DotaPlayerData.API;
using DotaPlayerData.Core.Services.Impl;
using FluentAssertions;
using Flurl.Http;
using Moq;

namespace DotaPlayerData.Tests.Services;

[TestFixture]
public class TeamServiceTests
{
    private Mock<IStratzApi> _mockStratzApi;
    private TeamService _teamService;


    [SetUp]
    public void Setup()
    {
        _mockStratzApi = new Mock<IStratzApi>();
        _teamService = new TeamService(_mockStratzApi.Object);
    }

    [Test]
    public async Task GetTeamInfos_WhenCalledWithCorrectInfos_ShouldRespondWithData()
    {
        const long teamId = 8970713;
        const string expectedData = "{\"members\":[{\"teamId\":8970713,\"firstMatchId\":6978024121,\"firstMatchDateTime\":\"2023-01-19T21:16:57\",\"lastMatchId\":7569915639,\"lastMatchDateTime\":\"2024-02-04T21:51:48\",\"steamAccount\":{\"id\":24129266,\"lastActiveTime\":\"2024-06-29T16:00:36\",\"profileUri\":\"https://steamcommunity.com/id/76561197984394994/\",\"realName\":\"\",\"timeCreated\":1155821600,\"countryCode\":\"BA\",\"stateCode\":\"02\",\"cityId\":0,\"communityVisibleState\":1,\"name\":\"( \u0361\u00b0 \u035cʖ \u0361\u00b0)\",\"avatar\":\"https://avatars.steamstatic.com/863a0ba2847ca70ef453ea4bdf28fab7d4c2ebcd_full.jpg\",\"primaryClanId\":103582791433341052,\"isDotaPlusSubscriber\":true,\"dotaPlusOriginalStartDate\":1621691677,\"isAnonymous\":false,\"isStratzPublic\":false,\"smurfFlag\":0,\"smurfCheckDate\":1707081048,\"lastMatchDateTime\":1719676836,\"lastMatchRegionId\":3,\"dotaAccountLevel\":77}},{\"teamId\":8970713,\"firstMatchId\":6978024121,\"firstMatchDateTime\":\"2023-01-19T21:16:57\",\"lastMatchId\":7569915639,\"lastMatchDateTime\":\"2024-02-04T21:51:48\",\"steamAccount\":{\"id\":25236716,\"lastActiveTime\":\"2024-06-30T21:40:18\",\"profileUri\":\"https://steamcommunity.com/id/eraile/\",\"realName\":\"Eraile\",\"timeCreated\":1160683107,\"countryCode\":\"FR\",\"cityId\":0,\"communityVisibleState\":1,\"name\":\"Père Dota\",\"avatar\":\"https://avatars.steamstatic.com/f1646b398adbb927a138886ccd669a8f84e2285f_full.jpg\",\"primaryClanId\":103582791464951016,\"isDotaPlusSubscriber\":true,\"dotaPlusOriginalStartDate\":1646995890,\"isAnonymous\":false,\"isStratzPublic\":false,\"seasonRank\":45,\"smurfFlag\":0,\"smurfCheckDate\":1718401715,\"lastMatchDateTime\":1719783618,\"lastMatchRegionId\":3,\"dotaAccountLevel\":26}},{\"teamId\":8970713,\"firstMatchId\":6978024121,\"firstMatchDateTime\":\"2023-01-19T21:16:57\",\"lastMatchId\":7569915639,\"lastMatchDateTime\":\"2024-02-04T21:51:48\",\"steamAccount\":{\"id\":46797520,\"lastActiveTime\":\"2024-06-27T21:34:08\",\"profileUri\":\"https://steamcommunity.com/id/76561198007063248/\",\"realName\":\"\",\"timeCreated\":1235830467,\"countryCode\":\"FR\",\"stateCode\":\"97\",\"cityId\":15642,\"communityVisibleState\":1,\"name\":\"Chandyr\",\"avatar\":\"https://avatars.steamstatic.com/4c7977b80295f2a46346f8ac96f086ad923fc2b6_full.jpg\",\"primaryClanId\":103582791429521408,\"isDotaPlusSubscriber\":true,\"dotaPlusOriginalStartDate\":1635711288,\"isAnonymous\":false,\"isStratzPublic\":false,\"smurfFlag\":0,\"smurfCheckDate\":1707081048,\"lastMatchDateTime\":1719524048,\"lastMatchRegionId\":3,\"dotaAccountLevel\":27}},{\"teamId\":8970713,\"firstMatchId\":6978024121,\"firstMatchDateTime\":\"2023-01-19T21:16:57\",\"lastMatchId\":7569915639,\"lastMatchDateTime\":\"2024-02-04T21:51:48\",\"steamAccount\":{\"id\":61875748,\"lastActiveTime\":\"2024-06-30T21:40:18\",\"profileUri\":\"https://steamcommunity.com/id/76561198022141476/\",\"realName\":\"Ben\",\"timeCreated\":1268000241,\"countryCode\":\"FR\",\"stateCode\":\"A8\",\"cityId\":16153,\"communityVisibleState\":1,\"name\":\"Panda\",\"avatar\":\"https://avatars.steamstatic.com/18625830b2f0270fa52c15655a4a9ee7569e600b_full.jpg\",\"primaryClanId\":103582791431949543,\"soloRank\":3440,\"isDotaPlusSubscriber\":true,\"dotaPlusOriginalStartDate\":1607268381,\"isAnonymous\":false,\"isStratzPublic\":false,\"smurfFlag\":0,\"smurfCheckDate\":1709406505,\"lastMatchDateTime\":1719783618,\"lastMatchRegionId\":3,\"dotaAccountLevel\":97}},{\"teamId\":8970713,\"firstMatchId\":6978024121,\"firstMatchDateTime\":\"2023-01-19T21:16:57\",\"lastMatchId\":7569915639,\"lastMatchDateTime\":\"2024-02-04T21:51:48\",\"steamAccount\":{\"id\":131261590,\"lastActiveTime\":\"2024-06-27T21:34:08\",\"profileUri\":\"https://steamcommunity.com/id/strustru/\",\"realName\":\"Damien\",\"timeCreated\":1368613677,\"countryCode\":\"FR\",\"stateCode\":\"97\",\"cityId\":15594,\"communityVisibleState\":1,\"name\":\"strustru\",\"avatar\":\"https://avatars.steamstatic.com/439c922dc9b84c3a09991b1015466e53b7d55bc5_full.jpg\",\"primaryClanId\":103582791429521408,\"isDotaPlusSubscriber\":false,\"isAnonymous\":false,\"isStratzPublic\":false,\"smurfFlag\":0,\"smurfCheckDate\":1706220500,\"lastMatchDateTime\":1719524048,\"lastMatchRegionId\":3,\"dotaAccountLevel\":5}},{\"teamId\":8970713,\"firstMatchId\":6993275721,\"firstMatchDateTime\":\"2023-01-29T20:50:16\",\"lastMatchId\":7554483677,\"lastMatchDateTime\":\"2024-01-25T21:51:23\",\"steamAccount\":{\"id\":25277135,\"lastActiveTime\":\"2024-06-27T21:34:08\",\"profileUri\":\"https://steamcommunity.com/id/76561197985542863/\",\"realName\":\"Julien\",\"timeCreated\":1161109912,\"countryCode\":\"FR\",\"stateCode\":\"97\",\"cityId\":0,\"communityVisibleState\":1,\"name\":\"Un bazooka pour un papillon\",\"avatar\":\"https://avatars.steamstatic.com/c24cba13ee075c2ecca5d7978ce0c6b38a3deab6_full.jpg\",\"primaryClanId\":103582791429521408,\"isDotaPlusSubscriber\":true,\"dotaPlusOriginalStartDate\":1639945308,\"isAnonymous\":false,\"isStratzPublic\":false,\"seasonRank\":21,\"smurfFlag\":0,\"smurfCheckDate\":1719235514,\"lastMatchDateTime\":1719524048,\"lastMatchRegionId\":3,\"dotaAccountLevel\":33}}],\"id\":8970713,\"name\":\"Krétains Organizacion\",\"logo\":\"https://steamusercontent-a.akamaihd.net/ugc/2035097676872804976/A03BBEAE4E2B4ACAE2FDF3B536F756EA27B3EBBF/\",\"bannerLogo\":\"https://steamusercontent-a.akamaihd.net/ugc/2035097676872793598/505EF3A693FA6E92A2930AE98CD0AA5B4AF70CEC/\",\"winCount\":1,\"lossCount\":13,\"lastMatchDateTime\":1707083508,\"isFollowed\":false,\"countryName\":\"\"}";
        
        _mockStratzApi.Setup(s => s.GetTeamInfos(teamId)).ReturnsAsync(expectedData);

        var result = await _teamService.GetTeam(teamId);

        result.Should().NotBeNull();
        result.Id.Should().Be(teamId);
        result.Name.Should().Be("Krétains Organizacion");
    }

    [Test]
    public void GetTeamInfos_WithIncorrectData_ShouldThrowJsonError()
    {
        const string fakeData = "Fake Data";
        const long teamId = 123456;
        
        _mockStratzApi.Setup(s => s.GetTeamInfos(teamId)).ReturnsAsync(fakeData);

        Assert.ThrowsAsync<JsonException>(async () =>
        {
            await _teamService.GetTeam(teamId);
        });
    }
    
    [Test]
    public void GetTeamInfos_WithAPIError_ShouldThrowHttpError()
    {
        const long teamId = 123456;
        
        _mockStratzApi.Setup(s => s.GetTeamInfos(teamId)).ThrowsAsync(new FlurlHttpException(null));

        Assert.ThrowsAsync<FlurlHttpException>(async () =>
        {
            await _teamService.GetTeam(teamId);
        });
    }
}