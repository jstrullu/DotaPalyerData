using RestSharp;

namespace DotaPlayerData.API;

// All the code in this file is included in all platforms.
public class OpenDotaApiClient : IOpenDotaApiClient
{
    private readonly IRestClient _restClient;

    public OpenDotaApiClient(IRestClient restClient)
    {
        _restClient = restClient;
    }
    
    public async Task<string> GetAllDotaHeroes()
    {
        var request = new RestRequest("heroes", Method.Get);

        var response = await _restClient.ExecuteAsync(request);

        if (!response.IsSuccessful)
        {
            throw new Exception($"Error calling OpenDota API: {response.ErrorMessage}");
        }

        if (response.Content == null)
            throw new Exception(response.ErrorException?.Message);

        return response.Content;
    }
}