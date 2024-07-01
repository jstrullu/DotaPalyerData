using System.Text.Json.Serialization;

namespace DotaPlayerData.Core.Models.Stratz;

public class Team
{
    [JsonPropertyName("members")]
    public List<Member> Members { get; set; }
    [JsonPropertyName("id")]
    public long Id { get; set; }
    [JsonPropertyName("name")]
    public string Name { get; set; }
    [JsonPropertyName("logo")]
    public string Logo { get; set; }
    [JsonPropertyName("bannerLogo")]
    public string BannerLogo { get; set; }
    [JsonPropertyName("winCount")]
    public int WinCount { get; set; }
    [JsonPropertyName("lossCount")]
    public int LossCount { get; set; }
    [JsonPropertyName("isFollowed")]
    public bool IsFollowed { get; set; }
    [JsonPropertyName("countryName")]
    public string CountryName { get; set; }
}