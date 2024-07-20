using DotaPlayerData.API.GraphQL;

namespace DotaPlayerData.API;

public interface IStratzApi
{
    Task<IGetPlayerInfosResult> GetPlayerInfos(long steamId);
    Task<string> GetTeamInfos(long teamId);
}