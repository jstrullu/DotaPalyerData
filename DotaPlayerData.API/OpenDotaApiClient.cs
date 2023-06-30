
using Flurl;
using Flurl.Http;

namespace DotaPlayerData.API;

// All the code in this file is included in all platforms.
public class OpenDotaApiClient : IOpenDotaApiClient
{
    private readonly string _baseUri;

    public OpenDotaApiClient()
    {
        _baseUri = "https://api.opendota.com/api/";
    }
    
    public async Task<string> GetAllDotaHeroes()
    {
        try
        {


            string heroesEndPoint = _baseUri.AppendPathSegment("heroes");

            var response = await heroesEndPoint.GetAsync();

            return await response.GetStringAsync();
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
            string matchEndpoint = _baseUri.AppendPathSegment($"players/{steamId}/matches?date=90");

            var response = await matchEndpoint.GetAsync();

            return await response.GetStringAsync();
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
            string playerEndpoint = _baseUri.AppendPathSegment($"players/{steamId}");

            var response = await playerEndpoint.GetAsync();
        
            return await response.GetStringAsync();
        }
        catch (FlurlHttpException e)
        {
            throw;
        }
    }
}