using System.Text.Json.Serialization;

namespace Domain;

public class Profile
{
    [JsonPropertyName("personaname")]
    public string Name { get; set; }
    public List<PlayerHero> Heroes { get; set; }
    public List<Match> Matches { get; set; }
}