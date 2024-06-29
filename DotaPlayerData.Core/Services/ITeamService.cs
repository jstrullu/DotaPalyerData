
using DotaPlayerData.Core.Models.Stratz;

namespace DotaPlayerData.Core.Services;

public interface ITeamService
{
    Task<Team> GetTeam(long teamId);
}