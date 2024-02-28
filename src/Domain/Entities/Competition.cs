namespace WagerWhaleApi.Domain.Entities;

public class Competition : BaseEntity
{
    public string Name { get; set; } = default!;
    public decimal RewardPerStage { get; set; }
    public decimal EntryFee { get; set; }
    public decimal PricePool { get;set; }
    public decimal ConsolationPrize { get; set; }
    public DateOnly StartDate { get; set; }
    public DateOnly? EndDate { get; set; }
}
