using WagerWhaleApi.Domain.Queries;

namespace WagerWhaleApi.Domain.Repositories;

public interface ICyclistRepository
{
    public Task<IReadOnlyCollection<Cyclist>> GetAllCyclistsAsync(CyclistsQuery query, CancellationToken token = default);
    public Task<PaginatedList<Cyclist>> GetAllCyclistsPaginatedAsync(PaginatedCyclistsQuery query, CancellationToken token = default);
}
