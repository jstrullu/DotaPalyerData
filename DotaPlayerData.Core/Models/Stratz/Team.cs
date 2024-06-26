namespace DotaPlayerData.Core.Models.Stratz;

public class Team
{
    public int TeamId { get; set; }
    public long FirstMatchId { get; set; }
    public DateTime FirstMatchDateTime { get; set; }
    public long LastMatchId { get; set; }
    public DateTime LastMatchDateTime { get; set; }
    public List<Member> Members { get; set; }
    public int Id { get; set; }
    public string Name { get; set; }
    public string Logo { get; set; }
    public string BannerLogo { get; set; }
    public int WinCount { get; set; }
    public int LossCount { get; set; }
    public bool IsFollowed { get; set; }
    public string CountryName { get; set; }
}