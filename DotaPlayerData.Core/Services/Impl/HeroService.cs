using System.Text.Json;
using DotaPlayerData.API;

namespace DotaPlayerData.Core.Services.Impl;

public class HeroService : IHeroService
{
    private readonly IOpenDotaApiClient _openDotaApiClient;
    
    public HeroService(IOpenDotaApiClient openDotaApiClient)
    {
        _openDotaApiClient = openDotaApiClient;
    }

    public async Task<IQueryable<PlayerHero>> GetTopHeroesForPlayer(long steamId)
    {
        var dotaHeroes = await GetAllDotaHeroes();

        if (!dotaHeroes.Any())
            throw new Exception("No global heroes list found");

        var playerMatches = await GetPlayerMatches(steamId);
        if (playerMatches == null)
            throw new Exception("No matches in list");
        
        List<PlayerHero> playerHeroes = new();
        
        playerHeroes.AddRange(playerMatches.Select(m => m.HeroId).Distinct().Select(h => new PlayerHero
        {
            HeroId = h.ToString()
        }));

        foreach (var hero in playerHeroes)
        {
            hero.Name = dotaHeroes.Find(h => h.Id == int.Parse(hero.HeroId))!.LocalizedName;
            hero.GamesPlayed = playerMatches.Count(m => m.HeroId == int.Parse(hero.HeroId));
            hero.WinCount = playerMatches.Count(m => m.HeroId == int.Parse(hero.HeroId) && m.MatchWon);
            
        }

        return playerHeroes.AsQueryable();

    }

    public async Task<List<Match>> GetPlayerMatches(long steamId)
    {
        var result = await _openDotaApiClient.GetPlayerMatches(steamId);
        return JsonSerializer.Deserialize<List<Match>>(result);
    }

    public async Task<List<Hero>> GetAllDotaHeroes()
    {
        var result = await _openDotaApiClient.GetAllDotaHeroes();
        return JsonSerializer.Deserialize<List<Hero>>(result);
    }
}