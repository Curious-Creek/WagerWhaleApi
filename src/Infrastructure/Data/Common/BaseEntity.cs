using WagerWhaleApi.Domain.Common;

namespace WagerWhaleApi.Infrastructure.Data.Common;

public abstract class BaseEntity
{
    public int Id { get; set; }
    public Guid DomainId { get; set; }
    public IReadOnlyCollection<BaseEvent> DomainEvents { get; private set; } = default!;
    
    public void ClearDomainEvents()
    {
        DomainEvents = new List<BaseEvent>().AsReadOnly();
    }
}
