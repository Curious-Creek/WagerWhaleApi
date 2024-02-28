using OneOf;
using WagerWhaleApi.Domain.Common;
using WagerWhaleApi.Domain.Entities;
using WagerWhaleApi.Domain.Repositories;

namespace WagerWhaleApi.Application.Competitions.Queries.GetCompetitionById;

public record GetCompetitionByIdQuery : IRequest<OneOf<Competition, NotFound>>
{
    public Guid Id { get; set; }
}

public class GetCompetitionByIdQueryHandler(ICompetitionRepository competitionRepository) : IRequestHandler<GetCompetitionByIdQuery, OneOf<Competition, NotFound>>
{
    public async Task<OneOf<Competition, NotFound>> Handle(GetCompetitionByIdQuery request, CancellationToken cancellationToken)
    {
        return await competitionRepository.GetCompetitionAsync(request.Id, cancellationToken);
    }
}
