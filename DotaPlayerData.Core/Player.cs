using System.Text.Json.Serialization;
using Microsoft.Maui.Controls.Internals;

namespace DotaPlayerData.Core;

public class Player
{
    [JsonPropertyName("profile")]
    public Profile Profile { get; set; }

    [JsonPropertyName("mmr_estimate")]
    public Mmr MmrEstimate { get; set; }

    [JsonPropertyName("rank_tier")]
    public int? RankTier { get; set; }

    public Ranks MainRank => (Ranks)((RankTier ?? 0) / 10);
    public int RankStars => (RankTier ?? 0) % 10;
    public string Rank => MainRank + " " + RankStars;
}