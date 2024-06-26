using DotaPlayerData.Core.Models.OpenDota;

namespace DotaPlayerData.Core.Models;

public class Player
{
    public Profile Profile { get; set; }
    public string CountryCode { get; set; }
    
    public Ranks MainRank { get; set; }
    public int RankStars { get; set; }

    public int WinCount { get; set; }
    public int MatchCount { get; set; }

    public int LossCount => MatchCount - WinCount;

    public Team Team { get; set; }
}