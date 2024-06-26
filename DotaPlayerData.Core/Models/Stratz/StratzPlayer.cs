using System.Text.Json.Serialization;

namespace DotaPlayerData.Core.Models.Stratz;

public class StratzPlayer
{
    [JsonPropertyName("identity")]
    public Identity Identity { get; set; }
    [JsonPropertyName("steamAccount")]
    public SteamAccount SteamAccount { get; set; }
    [JsonPropertyName("battlePass")]
    public List<BattlePass> BattlePass { get; set; }
    [JsonPropertyName("date")]
    public long Date { get; set; }
    [JsonPropertyName("lastRegionId")]
    public int LastRegionId { get; set; }
    [JsonPropertyName("ranks")]
    public List<Rank> Ranks { get; set; }
    [JsonPropertyName("languageCode")]
    public List<object> LanguageCode { get; set; }
    [JsonPropertyName("firstMatchDate")]
    public long FirstMatchDate { get; set; }
    [JsonPropertyName("matchCount")]
    public int MatchCount { get; set; }
    [JsonPropertyName("winCount")]
    public int WinCount { get; set; }
    [JsonPropertyName("names")]
    public List<Name> Names { get; set; }
    [JsonPropertyName("team")]
    public Team Team { get; set; }
    [JsonPropertyName("behaviorScore")]
    public int BehaviorScore { get; set; }
    [JsonPropertyName("steamAccountId")]
    public int SteamAccountId { get; set; }
    [JsonPropertyName("isFollowed")]
    public bool IsFollowed { get; set; }
}