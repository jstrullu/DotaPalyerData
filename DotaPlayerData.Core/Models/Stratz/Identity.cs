namespace DotaPlayerData.Core.Models.Stratz;

public class Identity
{
    public string CaptainJackIdentityId { get; set; }
    public string Name { get; set; }
    public int FeedLevel { get; set; }
    public int EmailLevel { get; set; }
    public bool DailyEmail { get; set; }
    public bool WeeklyEmail { get; set; }
    public bool MonthlyEmail { get; set; }
    public int ProCircuitFeedLevel { get; set; }
    public int ProCircuitEmailLevel { get; set; }
    public int ThemeType { get; set; }
    public int LanguageId { get; set; }
    public bool IsEmailValidated { get; set; }
    public int EmailHour { get; set; }
    public int LastDailyEmail { get; set; }
    public int LastWeeklyEmail { get; set; }
    public int LastMonthlyEmail { get; set; }
    public int LastLeagueDailyEmail { get; set; }
    public int LastTeamDailyEmail { get; set; }
    public int LastProCircuitDailyEmail { get; set; }
    public string UnsubscribeCode { get; set; }
    public int SteamAccountId { get; set; }
}