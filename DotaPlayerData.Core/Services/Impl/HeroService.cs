using System.Text.Json;
using DotaPlayerData.API;
using DotaPlayerData.Core.Models.OpenDota;

namespace DotaPlayerData.Core.Services.Impl;

public class HeroService(IOpenDotaApiClient openDotaApiClient, IMatchService matchService) : IHeroService
{
    public async Task<IQueryable<PlayerHero>> GetTopHeroesForPlayer(long steamId)
    {
        var dotaHeroes = await GetAllDotaHeroes();
        var heroesConstants = await GetHeroesConstants();

        if (dotaHeroes.Count == 0)
            throw new Exception("No global heroes list found");

        var playerMatches = await matchService.GetPlayerMatches(steamId);
        if (playerMatches == null || playerMatches.Count == 0)
            throw new Exception("No matches in list");
        
        List<PlayerHero> playerHeroes = [];
        
        playerHeroes.AddRange(playerMatches.Select(m => m.HeroId).Distinct().Select(h => new PlayerHero
        {
            HeroId = h.ToString()
        }));

        foreach (var hero in playerHeroes)
        {
            hero.Name = dotaHeroes.Find(h => h.Id == int.Parse(hero.HeroId))!.LocalizedName;
            hero.GamesPlayed = playerMatches.Count(m => m.HeroId == int.Parse(hero.HeroId));
            hero.WinCount = playerMatches.Count(m => m.HeroId == int.Parse(hero.HeroId) && m.MatchWon);
            hero.Avatar = heroesConstants[hero.HeroId].Icon;
        }

        return playerHeroes.AsQueryable();

    }

    private async Task<Dictionary<string, HeroeConstants>> GetHeroesConstants()
    {
        var result = await openDotaApiClient.GetHeroesConstants();
        return JsonSerializer.Deserialize<Dictionary<string, HeroeConstants>>(result);
    }

    public async Task<List<Hero>> GetAllDotaHeroes()
    {
        var result = await openDotaApiClient.GetAllDotaHeroes();
        return JsonSerializer.Deserialize<List<Hero>>(result);
    }
}