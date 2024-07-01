using System.Text.Json.Serialization;

namespace DotaPlayerData.Core.Models.Stratz;

public class TeamProfile
{
    [JsonPropertyName("teamId")]
    public int TeamId { get; set; }
    [JsonPropertyName("firstMatchId")]
    public long FirstMatchId { get; set; }
    [JsonPropertyName("firstMatchDateTime")]
    public DateTime FirstMatchDateTime { get; set; }
    [JsonPropertyName("lastMatchId")]
    public long LastMatchId { get; set; }
    [JsonPropertyName("lastMatchDateTime")]
    public DateTime LastMatchDateTime { get; set; }
    [JsonPropertyName("team")] 
    public Team Team { get; set; }
}