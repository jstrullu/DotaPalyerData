using DotaPlayerData.Core.Models.OpenDota;

namespace DotaPlayerData.Core.Services;

public interface IMatchService
{
    Task<List<Match>> GetPlayerMatches(long steamId);
}