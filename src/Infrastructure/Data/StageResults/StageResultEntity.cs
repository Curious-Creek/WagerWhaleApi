namespace WagerWhaleApi.Infrastructure.Data.StageResults;

public sealed class StageResultEntity
{
    public Guid CyclistId { get; set; }
    public Guid StageId { get; set; }
    public int Points { get; set; }
}
