namespace DotaPlayerData.Core.Models.Stratz;

public class Member
{
    public int TeamId { get; set; }
    public object FirstMatchId { get; set; }
    public DateTime FirstMatchDateTime { get; set; }
    public object LastMatchId { get; set; }
    public DateTime LastMatchDateTime { get; set; }
    public SteamAccount SteamAccount { get; set; }
}