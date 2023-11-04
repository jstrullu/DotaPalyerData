namespace DotaPlayerData.API;

public interface IStratzApi
{
    Task<string> GetPlayerInfos(long steamId);
}