using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json;
using DotaPlayerData.API;
using DotaPlayerData.Core.Models;
using DotaPlayerData.Core.Models.OpenDota;
using DotaPlayerData.Core.Models.Stratz;
using Flurl.Http;
using Profile = DotaPlayerData.Core.Models.Profile;
using Team = DotaPlayerData.Core.Models.Team;

[assembly:InternalsVisibleTo("DotaPlayerData.Tests")]
namespace DotaPlayerData.Core.Services.Impl;

public class PlayerService(IOpenDotaApiClient openDotaApiClient, IStratzApi stratzApi, ITeamService teamService) : IPlayerService
{

    public async Task<List<SearchPlayerResult>> SearchPlayer(string name)
    {
        try
        {
            var result = await openDotaApiClient.SearchPlayer(name);
            return JsonSerializer.Deserialize<List<SearchPlayerResult>>(result);
        }
        catch (JsonException)
        {
            throw;
        }
        catch (FlurlHttpException)
        {
            throw;
        }
    }
    
    public async Task<Player> GetCurrentPlayerInfos(long steamId)
    {
        var result = await openDotaApiClient.GetPlayerInfos(steamId).ConfigureAwait(false);
        
        var openDotaPlayer = JsonSerializer.Deserialize<OpenDotaPlayer>(result) ?? throw new InvalidOperationException();

        result = await stratzApi.GetPlayerInfos(steamId).ConfigureAwait(false);

        var stratzPlayer = JsonSerializer.Deserialize<StratzPlayer>(result);
        
        return GetMergedPlayerInfos(stratzPlayer, openDotaPlayer);
    }

    internal static Player GetMergedPlayerInfos(StratzPlayer stratzPlayer, OpenDotaPlayer openDotaPlayer)
    {
        return new Player
        {
            Profile = new Profile
            {
                Avatar = openDotaPlayer.Profile.Avatar,
                Name = openDotaPlayer.Profile.Name,
                AllNames = stratzPlayer.Names.Select(n => n.Naming).ToList()
            },
            CountryCode = openDotaPlayer.Profile.CountryCode,
            MainRank = openDotaPlayer.MainRank,
            RankStars = openDotaPlayer.RankStars,
            WinCount = stratzPlayer.WinCount,
            MatchCount = stratzPlayer.MatchCount,
            Team = new Team
            {
                Name = stratzPlayer.Team.Team.Name,
                Logo = stratzPlayer.Team.Team.Logo
            }
        };
    }
}