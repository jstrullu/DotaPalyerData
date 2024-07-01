using System.Text.Json;
using DotaPlayerData.API;
using DotaPlayerData.Core.Models.OpenDota;

namespace DotaPlayerData.Core.Services.Impl;

public class MatchService(IOpenDotaApiClient openDotaApiClient) : IMatchService
{
    public async Task<List<Match>> GetPlayerMatches(long steamId)
    {
        var result = await openDotaApiClient.GetPlayerMatches(steamId);
        return JsonSerializer.Deserialize<List<Match>>(result);
    }
}