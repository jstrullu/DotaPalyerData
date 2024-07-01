using DotaPlayerData.API.Configuration;
using Flurl;
using Flurl.Http;

namespace DotaPlayerData.API.Impl;

// All the code in this file is included in all platforms.
public class OpenDotaApiClient(OpenDotaConfiguration openDotaConfiguration) : IOpenDotaApiClient
{

    public async Task<string> GetAllDotaHeroes()
    {
        try
        {
            string heroesEndPoint = openDotaConfiguration.BaseUrl.AppendPathSegment("heroes");

            var response = await heroesEndPoint.GetAsync().ConfigureAwait(false);

            return await response.GetStringAsync().ConfigureAwait(false);
        }
        catch (FlurlHttpException ex)
        {
            throw;
        }
    }

    public async Task<string> GetPlayerMatches(long steamId)
    {
        try
        {
            string matchEndpoint = openDotaConfiguration.BaseUrl.AppendPathSegment($"players/{steamId}/matches");

            var response = await matchEndpoint.GetAsync().ConfigureAwait(false);

            return await response.GetStringAsync().ConfigureAwait(false);
        }
        catch (FlurlHttpException e)
        {
            throw;
        }
    }

    public async Task<string> GetPlayerInfos(long steamId)
    {
        try
        {
            string playerEndpoint = openDotaConfiguration.BaseUrl.AppendPathSegment($"players/{steamId}");

            var response = await playerEndpoint.GetAsync().ConfigureAwait(false);
        
            return await response.GetStringAsync().ConfigureAwait(false);
        }
        catch (FlurlHttpException e)
        {
            throw;
        }
    }

    public async Task<string> SearchPlayer(string name)
    {
        try
        {
            string searchEndpoint = openDotaConfiguration.BaseUrl.AppendPathSegment("search").SetQueryParam("q", name);
            var response = await searchEndpoint.GetAsync().ConfigureAwait(false);

            return await response.GetStringAsync().ConfigureAwait(false);
        }
        catch (FlurlHttpException e)
        {
            throw;
        }
    }

    public async Task<string> GetHeroesConstants()
    {
        string heroesConstantsEndpoint = openDotaConfiguration.BaseUrl.AppendPathSegment("constants/heroes");
        var response = await heroesConstantsEndpoint.GetAsync().ConfigureAwait(false);

        return await response.GetStringAsync().ConfigureAwait(false);
    }
}