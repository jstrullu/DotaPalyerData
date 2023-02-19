using System.Resources;
using System.Security.Cryptography;
using System.Text.Json.Serialization;

namespace Domain;

public class Player
{
    [JsonPropertyName("profile")]
    public Profile Profile { get; set; }

    [JsonPropertyName("mmr_estimate")]
    public MMR MMREstimate { get; set; }

    [JsonPropertyName("rank_tier")]
    public int? RankTier { get; set; }

    public string Rank 
    {
        get
        {
            var main = (Ranks)((RankTier ?? 0 / 10) % 10);
            var unit = RankTier % 10;
            return main.ToString() + " " + unit.ToString();
        }
        
    }
}