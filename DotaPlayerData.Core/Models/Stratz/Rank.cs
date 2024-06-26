namespace DotaPlayerData.Core.Models.Stratz;

public class Rank
{
    public int SeasonRankId { get; set; }
    public DateTime AsOfDateTime { get; set; }
    public bool IsCore { get; set; }
    public int Ranking { get; set; }
}