using System.Text.Json.Serialization;

namespace DotaPlayerData.Core.Models.Stratz;

public class Member
{
    [JsonPropertyName("teamId")]
    public int TeamId { get; set; }
    [JsonPropertyName("firstMatchId")]
    public object FirstMatchId { get; set; }
    [JsonPropertyName("firstMatchDateTime")]
    public DateTime FirstMatchDateTime { get; set; }
    [JsonPropertyName("lastMatchId")]
    public object LastMatchId { get; set; }
    [JsonPropertyName("lastMatchDateTime")]
    public DateTime LastMatchDateTime { get; set; }
    [JsonPropertyName("steamAccount")]
    public SteamAccount SteamAccount { get; set; }
}