using System.Text.Json.Serialization;

namespace DotaPlayerData.Core.Models.OpenDota;

public class Mmr
{
    [JsonPropertyName("estimate")]
    public int Estimate { get; set; }
}