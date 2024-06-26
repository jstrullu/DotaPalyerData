using System.Text.Json.Serialization;

namespace DotaPlayerData.Core.Models.Stratz;

public class SteamAccount
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    [JsonPropertyName("lastActiveTime")]
    public DateTime LastActiveTime { get; set; }
    [JsonPropertyName("profileUri")]
    public string ProfileUri { get; set; }
    [JsonPropertyName("realName")]
    public string RealName { get; set; }
    [JsonPropertyName("timeCreated")]
    public long TimeCreated { get; set; }
    [JsonPropertyName("countryCode")]
    public string CountryCode { get; set; }
    [JsonPropertyName("cityId")]
    public int CityId { get; set; }
    [JsonPropertyName("communityVisibleState")]
    public int CommunityVisibleState { get; set; }
    [JsonPropertyName("name")]
    public string Name { get; set; }
    [JsonPropertyName("avatar")]
    public string Avatar { get; set; }
    [JsonPropertyName("primaryClanId")]
    public long PrimaryClanId { get; set; }
    [JsonPropertyName("isDotaPluSubscriber")]
    public bool IsDotaPlusSubscriber { get; set; }
    [JsonPropertyName("dotaPlusOriginalStartDate")]
    public long DotaPlusOriginalStartDate { get; set; }
    [JsonPropertyName("isAnonymous")]
    public bool IsAnonymous { get; set; }
    [JsonPropertyName("isStratzPublic")]
    public bool IsStratzPublic { get; set; }
    [JsonPropertyName("seasonRank")]
    public int SeasonRank { get; set; }
    [JsonPropertyName("smurfFlag")]
    public int SmurfFlag { get; set; }
    [JsonPropertyName("smurfCheckDate")]
    public long SmurfCheckDate { get; set; }
    [JsonPropertyName("lastMatchDateTime")]
    public long LastMatchDateTime { get; set; }
    [JsonPropertyName("lastMatchRegionId")]
    public int LastMatchRegionId { get; set; }
    [JsonPropertyName("dotaAccountLevel")]
    public int DotaAccountLevel { get; set; }
    [JsonPropertyName("stateCode")]
    public string StateCode { get; set; }
    [JsonPropertyName("soloRank")]
    public int? SoloRank { get; set; }
}