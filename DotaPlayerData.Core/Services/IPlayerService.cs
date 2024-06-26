using DotaPlayerData.Core.Models;
using DotaPlayerData.Core.Models.OpenDota;

namespace DotaPlayerData.Core.Services;

public interface IPlayerService
{
    Task<List<SearchPlayerResult>> SearchPlayer(string name);
    Task<Player> GetCurrentPlayerInfos(long steamId);
}