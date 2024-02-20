using WagerWhaleApi.Infrastructure.Data.Common;

namespace WagerWhaleApi.Infrastructure.Data.Cyclists;

public sealed class CyclistEntity : BaseEntity
{
    public Guid TeamId { get; set; }
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
    public DateOnly DateOfBirth { get; set; }
}
