namespace DotaPlayerData.API;

public interface IStratzApi
{
    Task<string> GetPlayerInfos(long steamId);
    Task<string> GetTeamInfos(long teamId);
}