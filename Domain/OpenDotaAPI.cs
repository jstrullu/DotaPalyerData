using System.Text.Json;
using RestSharp;

namespace Domain;

public class OpenDotaApi
{
    private const string BaseUrl = "https://api.opendota.com/api";

    public async Task<List<PlayerHero>> GetTopHeroesForPlayer(long steamId)
    {
        using var client = new RestClient(BaseUrl);
        var heroes = await GetAllDotaHeroes(client);
        var request = new RestRequest($"players/{steamId}/matches?date=90", Method.Get);

        var response = await client.ExecuteAsync(request);

        if (!heroes.Any())
            throw new Exception("No global heroes list retrieved");

        if (!response.IsSuccessful)
            throw new Exception($"Error calling OpenDota API: {response.ErrorMessage}");
        

        if (response.Content == null)
            throw new Exception("No response content");

        var playerMatches = JsonSerializer.Deserialize<List<Match>>(response.Content);

        if (playerMatches == null)
            throw new Exception("No matches in list");

        List<PlayerHero> playerHeroes = new();
        
        playerHeroes.AddRange(playerMatches.Select(m => m.HeroId).Distinct().Select(h => new PlayerHero
        {
            HeroId = h.ToString()
        }));

        foreach (var hero in playerHeroes)
        {
            hero.Name = heroes.Find(h => h.Id == int.Parse(hero.HeroId))!.LocalizedName;
            hero.GamesPlayed = playerMatches.Count(m => m.HeroId == int.Parse(hero.HeroId));
            hero.WinCount = playerMatches.Count(m => m.HeroId == int.Parse(hero.HeroId) && m.MatchWon);
            
        }

        return playerHeroes.OrderByDescending(h => h.GamesPlayed).ThenByDescending(h => h.WinRate).Take(10).ToList();
        
    }

    private static async Task<List<Hero>> GetAllDotaHeroes(IRestClient client)
    {
        var request = new RestRequest("heroes", Method.Get);

        var response = await client.ExecuteAsync(request);

        if (!response.IsSuccessful)
        {
            throw new Exception($"Error calling OpenDota API: {response.ErrorMessage}");
        }

        if (response.Content == null)
            throw new Exception(response.ErrorException?.Message);
        
        return JsonSerializer.Deserialize<List<Hero>>(response.Content) ?? throw new InvalidOperationException();
    }

    public async Task<Player> GetCurrentPlayerInfos(long steamId)
    {
        using var client = new RestClient(BaseUrl);
        
        var request = new RestRequest($"players/{steamId}", Method.Get);
        var response = await client.ExecuteAsync(request);

        if (!response.IsSuccessful)
            throw new Exception($"Error calling OpenDota API: {response.ErrorMessage}");
        
        if (response.Content == null)
            throw new Exception(response.ErrorException?.Message);

        return JsonSerializer.Deserialize<Player>(response.Content) ?? throw new InvalidOperationException();
    }
}