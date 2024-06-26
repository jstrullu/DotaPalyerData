namespace DotaPlayerData.Core.Models.Stratz;

public class SteamAccount
{
    public int Id { get; set; }
    public DateTime LastActiveTime { get; set; }
    public string ProfileUri { get; set; }
    public string RealName { get; set; }
    public DateTime TimeCreated { get; set; }
    public string CountryCode { get; set; }
    public int CityId { get; set; }
    public int CommunityVisibleState { get; set; }
    public string Name { get; set; }
    public string Avatar { get; set; }
    public long PrimaryClanId { get; set; }
    public bool IsDotaPlusSubscriber { get; set; }
    public DateTime DotaPlusOriginalStartDate { get; set; }
    public bool IsAnonymous { get; set; }
    public bool IsStratzPublic { get; set; }
    public int SeasonRank { get; set; }
    public int SmurfFlag { get; set; }
    public DateTime SmurfCheckDate { get; set; }
    public DateTime LastMatchDateTime { get; set; }
    public int LastMatchRegionId { get; set; }
    public int DotaAccountLevel { get; set; }
    public string StateCode { get; set; }
    public int? SoloRank { get; set; }
}