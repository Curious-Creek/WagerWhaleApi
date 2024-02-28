namespace WagerWhaleApi.Domain.Entities;

public sealed class Cyclist : BaseEntity
{
    public Guid TeamId { get; set; }
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
    public DateOnly DateOfBirth { get; set; }
}
