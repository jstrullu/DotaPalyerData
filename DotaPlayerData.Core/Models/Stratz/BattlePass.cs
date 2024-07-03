

using System.Text.Json.Serialization;

namespace DotaPlayerData.Core.Models.Stratz;

public class BattlePass
{
    [JsonPropertyName("eventId")]
    public int EventId { get; set; }
    [JsonPropertyName("level")]
    public int Level { get; set; }
    [JsonPropertyName("countryCode")]
    public string CountryCode { get; set; }
    [JsonPropertyName("bracket")]
    public int Bracket { get; set; }
    [JsonPropertyName("isAnonymous")]
    public bool IsAnonymous { get; set; }
}