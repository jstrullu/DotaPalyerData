using System.Text.Json.Serialization;

namespace DotaPlayerData.Core;

public class Mmr
{
    [JsonPropertyName("estimate")]
    public int Estimate { get; set; }
}