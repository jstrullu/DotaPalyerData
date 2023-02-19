using System.Text.Json.Serialization;

namespace Domain;

public class Player
{
    [JsonPropertyName("profile")]
    public Profile Profile { get; set; }
}