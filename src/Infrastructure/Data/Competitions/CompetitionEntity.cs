using WagerWhaleApi.Infrastructure.Data.Common;

namespace WagerWhaleApi.Infrastructure.Data.Competitions;

public sealed class CompetitionEntity : BaseEntity
{
    public string Name { get; set; } = default!;
    public decimal RewardPerStage { get; set; }
    public decimal EntryFee { get; set; }
    public decimal PricePool { get;set; }
    public decimal ConsolationPrize { get; set; }
    public DateOnly StartDate { get; set; }
}
