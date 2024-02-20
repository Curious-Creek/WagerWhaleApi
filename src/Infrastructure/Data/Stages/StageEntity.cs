using WagerWhaleApi.Infrastructure.Data.Common;

namespace WagerWhaleApi.Infrastructure.Data.Stages;

public sealed class StageEntity : BaseEntity
{
    public Guid ParentStageId { get; set; }
    public string Name { get; set; } = default!;
}
