namespace DotaPlayerData.Core.Models.Stratz;

public class Player
{
    public Identity Identity { get; set; }
    public SteamAccount SteamAccount { get; set; }
    public List<BattlePass> BattlePass { get; set; }
    public DateTime Date { get; set; }
    public int LastRegionId { get; set; }
    public List<Rank> Ranks { get; set; }
    public List<object> LanguageCode { get; set; }
    public DateTime FirstMatchDate { get; set; }
    public int MatchCount { get; set; }
    public int WinCount { get; set; }
    public List<Name> Names { get; set; }
    public Team Team { get; set; }
    public int BehaviorScore { get; set; }
    public int SteamAccountId { get; set; }
    public bool IsFollowed { get; set; }
}