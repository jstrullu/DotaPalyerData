using DotaPlayerData.Core;

namespace DotaPlayerData.UI.Data;

public class SearchController
{
    private readonly IHeroService _heroService;
    public SearchController(IHeroService heroService)
    {
        _heroService = heroService;
    }

    public async Task<List<PlayerHero>> SearchTopPlayerHeroes(long steamId)
    {
        return await _heroService.GetTopHeroesForPlayer(steamId);
    }
}