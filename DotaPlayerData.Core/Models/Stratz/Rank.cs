using System.Text.Json.Serialization;

namespace DotaPlayerData.Core.Models.Stratz;

public class Rank
{
    [JsonPropertyName("seasonRankId")]
    public int SeasonRankId { get; set; }
    [JsonPropertyName("asOfDateTime")]
    public DateTime AsOfDateTime { get; set; }
    [JsonPropertyName("isCore")]
    public bool IsCore { get; set; }
    [JsonPropertyName("rank")]
    public int Ranking { get; set; }
}