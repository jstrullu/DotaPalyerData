using DotaPlayerData.API.Configuration;
using DotaPlayerData.API.GraphQL;
using Flurl;
using Flurl.Http;
using STRATZ;

namespace DotaPlayerData.API.Impl;

public class StratzApi(StratzConfiguration stratzConfiguration, IStratzClient stratzClient) : IStratzApi
{
    public async Task<IGetPlayerInfosResult> GetPlayerInfos(long steamId)
    {
        try
        {
            var response = await stratzClient.GetPlayerInfos.ExecuteAsync(steamId).ConfigureAwait(false);
            
            return response.Data;
        }
        catch (FlurlHttpException e)
        {
            throw;
        }
    }

    public async Task<string> GetTeamInfos(long teamId)
    {
        try
        {
            string teamEndPoint = stratzConfiguration.BaseUrl.AppendPathSegment($"team/{teamId}");

            var response = await teamEndPoint.WithOAuthBearerToken(stratzConfiguration.ApiKey).GetAsync()
                .ConfigureAwait(false);

            return await response.GetStringAsync().ConfigureAwait(false);
        }
        catch (FlurlHttpException e)
        {
            throw;
        }
    }
}