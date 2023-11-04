using Flurl;
using Flurl.Http;

namespace DotaPlayerData.API.Impl;

public class StratzApi : IStratzApi
{
    private const string ApiKey =
        "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJTdWJqZWN0IjoiMGVjNTFiY2UtOWJjOS00NDM0LTlhYTMtNTFmMGNhYjIzYWJjIiwiU3RlYW1JZCI6IjI1Mjc3MTM1IiwibmJmIjoxNjkzNzU4NzUxLCJleHAiOjE3MjUyOTQ3NTEsImlhdCI6MTY5Mzc1ODc1MSwiaXNzIjoiaHR0cHM6Ly9hcGkuc3RyYXR6LmNvbSJ9.J-MuI-ulbSyzgGOV35N28JWm0asZSDYgzPc2GhGrlY8";

    private readonly string _baseUri;
    public StratzApi()
    {
        _baseUri = "https://api.stratz.com//api/v1/";
    }
    
    public async Task<string> GetPlayerInfos(long steamId)
    {
        try
        {
            string playerEndpoint = _baseUri.AppendPathSegment($"player/{steamId}");

            var response = await playerEndpoint.GetAsync().ConfigureAwait(false);
            return await response.GetStringAsync().ConfigureAwait(false);
        }
        catch (FlurlHttpException e)
        {
            throw;
        }
    }
}