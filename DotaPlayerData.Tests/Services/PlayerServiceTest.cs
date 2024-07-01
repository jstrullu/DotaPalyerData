using System.Text.Json;
using DotaPlayerData.API;
using DotaPlayerData.Core.Models.OpenDota;
using DotaPlayerData.Core.Models.Stratz;
using DotaPlayerData.Core.Services;
using DotaPlayerData.Core.Services.Impl;
using FluentAssertions;
using Flurl.Http;
using Moq;
using Match = DotaPlayerData.Core.Models.OpenDota.Match;

namespace DotaPlayerData.Tests.Services;

[TestFixture]
public class PlayerServiceTest
{
    private PlayerService _playerService;
    private Mock<IOpenDotaApiClient> _mockOpenDota;
    private Mock<IStratzApi> _mockStratz;
    private Mock<ITeamService> _mockTeamService;

    [SetUp]
    public void Setup(){
        _mockOpenDota = new Mock<IOpenDotaApiClient>();
        _mockStratz = new Mock<IStratzApi>();
        _mockTeamService = new Mock<ITeamService>();
        _playerService = new PlayerService(_mockOpenDota.Object, _mockStratz.Object, _mockTeamService.Object);
    }

    [Test]
    public void MergePlayerData_WithCorrectData_ShouldReturnPlayer()
    {
        //Arrange
        var openDotaPlayer = new OpenDotaPlayer
        {
            Profile = new Profile
            {
                Avatar = "",
                CountryCode = "FR",
                Name = "Test",
                Heroes = [],
                Matches = []
            },
            RankTier = 31
        };

        var stratzPlayer = new StratzPlayer
        {
            Names = [new Name{Naming = "Toto"}, new Name{Naming = "Tata"}],
            WinCount = 10,
            MatchCount = 20,
            Team = new TeamProfile
            {
                Team = new Team{
                    Name = "Team",
                    Logo = ""
                }
            }
        };
        
        //Act
        var result = PlayerService.GetMergedPlayerInfos(stratzPlayer, openDotaPlayer);
        
        //Assert
        result.Should().NotBeNull();
        result.Profile.Avatar.Should().Be(openDotaPlayer.Profile.Avatar);
        result.Profile.Name.Should().Be(openDotaPlayer.Profile.Name);
        result.CountryCode.Should().Be(openDotaPlayer.Profile.CountryCode);
        result.MatchCount.Should().Be(stratzPlayer.MatchCount);
        result.WinCount.Should().Be(stratzPlayer.WinCount);
        result.LossCount.Should().Be(result.MatchCount - result.WinCount);
        result.Profile.AllNames.Count.Should().Be(stratzPlayer.Names.Count);
        result.Profile.AllNames[0].Should().Be(stratzPlayer.Names[0].Naming);
        result.Team.Should().NotBeNull();
        result.Team.Name.Should().Be(stratzPlayer.Team.Team.Name);
    }

    [Test]
    public async Task SearchPlayer_When200_ShouldReturnData()
    {
        //Arrange
        string searchResult =
            "[" +
            "{\"account_id\":352874473,\"personaname\":\"Mere Dota\",\"avatarfull\":\"https://avatars.steamstatic.com/cb2a4cc08aa9f3676e226597e08c528f66ffdd6d_full.jpg\",\"similarity\":37.515846}," +
            "{\"account_id\":25236716,\"personaname\":\"Père Dota\",\"avatarfull\":\"https://avatars.steamstatic.com/f1646b398adbb927a138886ccd669a8f84e2285f_full.jpg\",\"last_match_time\":\"2024-06-25T21:16:34.000Z\",\"similarity\":31.584442}" +
            "]";


        _mockOpenDota.Setup(o => o.SearchPlayer(It.IsAny<string>())).ReturnsAsync(searchResult);

        var result = await _playerService.SearchPlayer("");

        result.Should().NotBeNull();
        result.Count.Should().Be(2);
        result[1].PersonaName.Should().Be("Père Dota");

    }

    [Test]
    public void SearchPlayer_WithError_ShouldThrow()
    {
        _mockOpenDota.Setup(o => o.SearchPlayer(It.IsAny<string>())).ThrowsAsync(new FlurlHttpException(null));

        Assert.ThrowsAsync<FlurlHttpException>(async () =>
        {
            await _playerService.SearchPlayer("Toto");
        });
    }

    [Test]
    public void SearchPlayer_WithDataError_ShouldThrowDeserialize()
    {
        const string fakeData = "fake data, for error";

        _mockOpenDota.Setup(o => o.SearchPlayer(It.IsAny<string>())).ReturnsAsync(fakeData);

        Assert.ThrowsAsync<JsonException>(async () =>
        {
            await _playerService.SearchPlayer("Toto");
        });
    }
}
