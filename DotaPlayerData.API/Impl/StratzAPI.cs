using DotaPlayerData.API.Configuration;
using Flurl;
using Flurl.Http;

namespace DotaPlayerData.API.Impl;

public class StratzApi(StratzConfiguration stratzConfiguration) : IStratzApi
{
    private readonly StratzConfiguration _stratzConfiguration = stratzConfiguration;

    public async Task<string> GetPlayerInfos(long steamId)
    {
        try
        {
            string playerEndpoint = _stratzConfiguration.BaseUrl.AppendPathSegment($"player/{steamId}");

            var response = await playerEndpoint.WithOAuthBearerToken(_stratzConfiguration.ApiKey).GetAsync().ConfigureAwait(false);
            return await response.GetStringAsync().ConfigureAwait(false);
        }
        catch (FlurlHttpException e)
        {
            throw;
        }
    }
}