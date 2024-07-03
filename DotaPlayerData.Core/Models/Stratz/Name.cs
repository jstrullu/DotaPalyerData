using System.Text.Json.Serialization;

namespace DotaPlayerData.Core.Models.Stratz;

public class Name
{
    [JsonPropertyName("name")]
    public string Naming { get; set; }
    [JsonPropertyName("lastseendatetime")]
    public long LastSeenDateTime { get; set; }
}