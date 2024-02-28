using OneOf;

namespace WagerWhaleApi.Domain.Repositories;

public interface ICompetitionRepository
{
    public Task<Guid> CreateCompetitionAsync(Competition competition, CancellationToken token = default);
    public Task<OneOf<Competition, NotFound>> GetCompetitionAsync(Guid competitionId, CancellationToken token = default);
    public Task<IReadOnlyCollection<Competition>> GetAllCompetitionsAsync(CancellationToken token = default);
}
