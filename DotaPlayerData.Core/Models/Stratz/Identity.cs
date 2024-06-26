using System.Text.Json.Serialization;

namespace DotaPlayerData.Core.Models.Stratz;

public class Identity
{
    [JsonPropertyName("captainJackIdentityId")]
    public string CaptainJackIdentityId { get; set; }
    [JsonPropertyName("name")]
    public string Name { get; set; }
    [JsonPropertyName("feedLevel")]
    public int FeedLevel { get; set; }
    [JsonPropertyName("emailLevel")]
    public int EmailLevel { get; set; }
    [JsonPropertyName("dailyEmail")]
    public bool DailyEmail { get; set; }
    [JsonPropertyName("weeklyEmail")]
    public bool WeeklyEmail { get; set; }
    [JsonPropertyName("monthlyEmail")]
    public bool MonthlyEmail { get; set; }
    [JsonPropertyName("proCircuitFeedLevel")]
    public int ProCircuitFeedLevel { get; set; }
    [JsonPropertyName("proCircuitEmailLevel")]
    public int ProCircuitEmailLevel { get; set; }
    [JsonPropertyName("themeType")]
    public int ThemeType { get; set; }
    [JsonPropertyName("languageId")]
    public int LanguageId { get; set; }
    [JsonPropertyName("isEmailValidated")]
    public bool IsEmailValidated { get; set; }
    [JsonPropertyName("emailHour")]
    public int EmailHour { get; set; }
    [JsonPropertyName("lastDailyEmail")]
    public long LastDailyEmail { get; set; }
    [JsonPropertyName("lastWeeklyEmail")]
    public long LastWeeklyEmail { get; set; }
    [JsonPropertyName("lastMonthlyEmail")]
    public long LastMonthlyEmail { get; set; }
    [JsonPropertyName("lastLeagueDailyEmail")]
    public long LastLeagueDailyEmail { get; set; }
    [JsonPropertyName("lastTeamDailyEmail")]
    public long LastTeamDailyEmail { get; set; }
    [JsonPropertyName("lastProCircuitDailyEmail")]
    public long LastProCircuitDailyEmail { get; set; }
    [JsonPropertyName("unsubscribeCode")]
    public string UnsubscribeCode { get; set; }
    [JsonPropertyName("steamAccountId")]
    public int SteamAccountId { get; set; }
}