using System.Text.Json;
using DotaPlayerData.API;
using DotaPlayerData.Core.Models.OpenDota;
using DotaPlayerData.Core.Services;
using DotaPlayerData.Core.Services.Impl;
using FluentAssertions;
using Moq;
using Match = DotaPlayerData.Core.Models.OpenDota.Match;

namespace DotaPlayerData.Tests.Services;

[TestFixture]
public class HeroServiceTest
{
    private Mock<IOpenDotaApiClient> _mockOpenDotaApi;
    private Mock<IMatchService> _mockMatchService;
    private IHeroService _heroService;

    [SetUp]
    public void Setup()
    {
        _mockOpenDotaApi = new Mock<IOpenDotaApiClient>();
        _mockMatchService = new Mock<IMatchService>();
        _heroService = new HeroService(_mockOpenDotaApi.Object, _mockMatchService.Object);
    }
    
    [Test]
    public async Task GetTopHeroesForPlayer_ReturnsCorrectData()
    {
        // Arrange
        long steamId = 12345;
        var fakeDotaHeroes = new List<Hero>
        {
            new Hero { Id = 1, LocalizedName = "Hero1" },
            new Hero { Id = 2, LocalizedName = "Hero2" }
        };
        var fakeConstants = new Dictionary<int, HeroeConstants>
        {
            {1, new HeroeConstants
            {
                Icon = "Test"
            }},
            {2, new HeroeConstants
            {
                Icon = "toto"
            }}
        };
        var fakePlayerMatches = new List<Match>
        {
            new Match { HeroId = 1, RadiantWin = true },
            new Match { HeroId = 1, RadiantWin = false },
            new Match { HeroId = 2, RadiantWin = true }
        };
        _mockOpenDotaApi.Setup(s => s.GetAllDotaHeroes()).ReturnsAsync(JsonSerializer.Serialize(fakeDotaHeroes));
        _mockOpenDotaApi.Setup(s => s.GetHeroesConstants()).ReturnsAsync(JsonSerializer.Serialize(fakeConstants));
        _mockMatchService.Setup(s => s.GetPlayerMatches(steamId)).ReturnsAsync(fakePlayerMatches);

        // Act
        var result = (await _heroService.GetTopHeroesForPlayer(steamId)).ToList();

        // Assert
        result.Should().NotBeNull();
        result.Count.Should().Be(2);
        var hero1Stats = result.First(m => m.HeroId == "1");
        hero1Stats.GamesPlayed.Should().Be(2);
        hero1Stats.WinCount.Should().Be(1);
        hero1Stats.Avatar.Should().Be("Test");

        var hero2Stats = result.First(h => h.HeroId == "2");
        hero2Stats.GamesPlayed.Should().Be(1);
        hero2Stats.WinCount.Should().Be(1);
        hero2Stats.Avatar.Should().Be("toto");
    }
    
    [Test]
    public async Task GetTopHeroesForPlayer_ReturnsNoDataForHeroes()
    {
        // Arrange
        long steamId = 12345;
        var fakeDotaHeroes = new List<Hero>();
        var fakePlayerMatches = new List<Match>
        {
            new Match { HeroId = 1, RadiantWin = true },
            new Match { HeroId = 1, RadiantWin = false },
            new Match { HeroId = 2, RadiantWin = true }
        };
        _mockOpenDotaApi.Setup(s => s.GetAllDotaHeroes()).ReturnsAsync(JsonSerializer.Serialize(fakeDotaHeroes));
        _mockOpenDotaApi.Setup(s => s.GetPlayerMatches(steamId)).ReturnsAsync(JsonSerializer.Serialize(fakePlayerMatches));

        // Act
        Func<Task> act = async () =>
        {
            await _heroService.GetTopHeroesForPlayer(steamId);
        };

        // Assert
        await act.Should().ThrowAsync<Exception>().WithMessage("No global heroes list found");
    }
    
    [Test]
    public async Task GetTopHeroesForPlayer_ReturnsNoDataForMatches()
    {
        // Arrange
        long steamId = 12345;
        var fakeDotaHeroes = new List<Hero>{
            new Hero { Id = 1, LocalizedName = "Hero1" },
            new Hero { Id = 2, LocalizedName = "Hero2" }
        };
        var fakePlayerMatches = new List<Match>();
        _mockOpenDotaApi.Setup(s => s.GetAllDotaHeroes()).ReturnsAsync(JsonSerializer.Serialize(fakeDotaHeroes));
        _mockOpenDotaApi.Setup(s => s.GetPlayerMatches(steamId)).ReturnsAsync(JsonSerializer.Serialize(fakePlayerMatches));

        // Act
        Func<Task> act = async () =>
        {
            await _heroService.GetTopHeroesForPlayer(steamId);
        };

        // Assert
        await act.Should().ThrowAsync<Exception>().WithMessage("No matches in list");
    }
    
    [Test]
    public async Task GetTopHeroesForPlayer_ReturnsNullForMatches()
    {
        // Arrange
        long steamId = 12345;
        var fakeDotaHeroes = new List<Hero>{
            new Hero { Id = 1, LocalizedName = "Hero1" },
            new Hero { Id = 2, LocalizedName = "Hero2" }
        };
        var fakePlayerMatches = (List<Match>) null;
        _mockOpenDotaApi.Setup(s => s.GetAllDotaHeroes()).ReturnsAsync(JsonSerializer.Serialize(fakeDotaHeroes));
        _mockOpenDotaApi.Setup(s => s.GetPlayerMatches(steamId)).ReturnsAsync(JsonSerializer.Serialize(fakePlayerMatches));

        // Act
        Func<Task> act = async () =>
        {
            await _heroService.GetTopHeroesForPlayer(steamId);
        };

        // Assert
        await act.Should().ThrowAsync<Exception>().WithMessage("No matches in list");
    }
}