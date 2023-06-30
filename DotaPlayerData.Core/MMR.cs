using System.Text.Json.Serialization;

namespace DotaPlayerData.Core;

public class MMR
{
    [JsonPropertyName("estimate")]
    public int Estimate { get; set; }
}