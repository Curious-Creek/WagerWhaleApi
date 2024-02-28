namespace Blazor.Domain.Competitions;

public sealed class CompetitionViewModel
{
    public string Name { get; set; } = default!;
    public decimal RewardPerStage { get; set; }
    public decimal EntryFee { get; set; }
    public decimal PricePool { get;set; }
    public decimal ConsolationPrize { get; set; }
    public DateOnly StartDate { get; set; }

    public CompetitionViewModel(string name, decimal rewardPerStage, decimal entryFee, decimal pricePool, decimal consolationPrize, DateOnly startDate)
    {
        Name = name;
        RewardPerStage = rewardPerStage;
        EntryFee = entryFee;
        PricePool = pricePool;
        ConsolationPrize = consolationPrize;
        StartDate = startDate;
    }
    
    public CompetitionViewModel(Competition competition)
    {
        Name = competition.Name;
        RewardPerStage = competition.RewardPerStage;
        EntryFee = competition.EntryFee;
        PricePool = competition.PricePool;
        ConsolationPrize = competition.ConsolationPrize;
        StartDate = competition.StartDate;
    }
}
