namespace DotaPlayerData.Core.Models.Stratz;

public class BattlePass
{
    public int EventId { get; set; }
    public int Level { get; set; }
    public string CountryCode { get; set; }
    public int Bracket { get; set; }
    public bool IsAnonymous { get; set; }
}