using WagerWhaleApi.Domain.Entities;
using WagerWhaleApi.Domain.Repositories;

namespace WagerWhaleApi.Application.Competitions.Queries.GetCompetitions;

public record GetCompetitionsQuery : IRequest<IReadOnlyCollection<Competition>>
{
}

public class GetCompetitionsQueryHandler(ICompetitionRepository competitionRepository) : IRequestHandler<GetCompetitionsQuery, IReadOnlyCollection<Competition>>
{
    public async Task<IReadOnlyCollection<Competition>> Handle(GetCompetitionsQuery request, CancellationToken cancellationToken)
    {
        return await competitionRepository.GetAllCompetitionsAsync(cancellationToken);
    }
}
