using System.Text.Json.Serialization;

namespace DotaPlayerData.Core.Models.OpenDota;

public class OpenDotaPlayer
{
    [JsonPropertyName("profile")]
    public Profile Profile { get; set; }

    [JsonPropertyName("rank_tier")]
    public int? RankTier { get; set; }

    public Ranks MainRank => (Ranks)((RankTier ?? 0) / 10);
    public int RankStars => (RankTier ?? 0) % 10;
    public string Rank => MainRank + " " + RankStars;
}