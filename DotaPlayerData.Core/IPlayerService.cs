namespace DotaPlayerData.Core;

public interface IPlayerService
{
    Task<List<SearchPlayerResult>> SearchPlayer(string name);
}