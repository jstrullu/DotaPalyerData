using DotaPlayerData.API.Configuration;
using Flurl;
using Flurl.Http;

namespace DotaPlayerData.API.Impl;

public class StratzApi(StratzConfiguration stratzConfiguration) : IStratzApi
{
    public async Task<string> GetPlayerInfos(long steamId)
    {
        try
        {
            string playerEndpoint = stratzConfiguration.BaseUrl.AppendPathSegment($"player/{steamId}");

            var response = await playerEndpoint.WithOAuthBearerToken(stratzConfiguration.ApiKey).GetAsync().ConfigureAwait(false);
            return await response.GetStringAsync().ConfigureAwait(false);
        }
        catch (FlurlHttpException e)
        {
            throw;
        }
    }
}