using DotaPlayerData.Core.Models.OpenDota;

namespace DotaPlayerData.Core.Services;

public interface IHeroService
{
    Task<List<Hero>> GetAllDotaHeroes();
    Task<IQueryable<PlayerHero>> GetTopHeroesForPlayer(long steamId);
}