using System.Text.Json.Serialization;

namespace Domain;

public class MMR
{
    [JsonPropertyName("estimate")]
    public int Estimate { get; set; }
}