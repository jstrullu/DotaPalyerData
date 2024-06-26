using System.Text.Json;
using DotaPlayerData.API;

namespace DotaPlayerData.Core.Services.Impl;

public class PlayerService : IPlayerService
{
    private readonly IOpenDotaApiClient _openDotaApiClient;

    public PlayerService(IOpenDotaApiClient openDotaApiClient)
    {
        _openDotaApiClient = openDotaApiClient;
    }
    
    public async Task<List<SearchPlayerResult>> SearchPlayer(string name)
    {
        try
        {
            var result = await _openDotaApiClient.SearchPlayer(name);
            return JsonSerializer.Deserialize<List<SearchPlayerResult>>(result);
        }
        catch (JsonException e)
        {
            throw;
        }
    }
    
    public async Task<Player> GetCurrentPlayerInfos(long steamId)
    {
        var result = await _openDotaApiClient.GetPlayerInfos(steamId);

        return JsonSerializer.Deserialize<Player>(result) ?? throw new InvalidOperationException();
    }
}