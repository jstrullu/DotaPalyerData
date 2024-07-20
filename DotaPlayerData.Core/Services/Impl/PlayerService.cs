using System.Runtime.CompilerServices;
using System.Text.Json;
using DotaPlayerData.API;
using DotaPlayerData.API.GraphQL;
using DotaPlayerData.Core.Models;
using DotaPlayerData.Core.Models.OpenDota;
using DotaPlayerData.Core.Models.Stratz;
using Profile = DotaPlayerData.Core.Models.Profile;
using Team = DotaPlayerData.Core.Models.Team;
using Flurl.Http;

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

        var playerData = await stratzApi.GetPlayerInfos(steamId).ConfigureAwait(false);

        
        
        return GetMergedPlayerInfos(playerData.Player, openDotaPlayer);
    }

    internal static Player GetMergedPlayerInfos(IGetPlayerInfos_Player stratzPlayer, OpenDotaPlayer openDotaPlayer)
    {
        return new Player
        {
            Profile = new Profile
            {
                Avatar = openDotaPlayer.Profile.Avatar,
                Name = openDotaPlayer.Profile.Name,
                AllNames = stratzPlayer.Names!.Select(n => n.Name).ToList()
            },
            CountryCode = openDotaPlayer.Profile.CountryCode,
            MainRank = openDotaPlayer.MainRank,
            RankStars = openDotaPlayer.RankStars,
            WinCount = stratzPlayer.WinCount ?? 0,
            MatchCount = stratzPlayer.MatchCount ?? 0,
            Team = new Team
            {
                Name = stratzPlayer.SteamAccount.Guild.Guild.Name,
                Logo = stratzPlayer.SteamAccount.Guild.Guild.Logo
            }
        };
    }
}