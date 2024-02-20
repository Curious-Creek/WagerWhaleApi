namespace WagerWhaleApi.Infrastructure.Data.Common;

public abstract class BaseEntity
{
    public int Id { get; set; }
    public Guid DomainId { get; set; }
}
