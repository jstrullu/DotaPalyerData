using System.Text.Json.Serialization;

namespace DotaPlayerData.Core;

public class SearchPlayerResult
{
    [JsonPropertyName("account_id")]
    public int AccountId { get; set; }

    [JsonPropertyName("avatarfull")]
    public string AvatarFull { get; set; }
    
    [JsonPropertyName("personaname")] 
    public string PersonaName { get; set; }
    
    [JsonPropertyName("last_match_time")]
    public string LastMatchTime { get; set; }
    
    [JsonPropertyName("similarity")]
    public float Similarity { get; set; }
}