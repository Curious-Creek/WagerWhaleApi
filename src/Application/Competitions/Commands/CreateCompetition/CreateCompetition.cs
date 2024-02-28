using WagerWhaleApi.Domain.Common;
using WagerWhaleApi.Domain.Entities;
using WagerWhaleApi.Domain.Repositories;
using OneOf;

namespace WagerWhaleApi.Application.Competitions.Commands.CreateCompetition;

public record CreateCompetitionCommand(
    string Name,
    decimal EntryFee,
    DateOnly StartDate) : IRequest<OneOf<Guid, AlreadyExists>>;

public class CreateCompetitionCommandHandler(ICompetitionRepository competitionRepository, IMapper mapper)
    : IRequestHandler<CreateCompetitionCommand, OneOf<Guid, AlreadyExists>>
{
    public async Task<OneOf<Guid, AlreadyExists>> Handle(
        CreateCompetitionCommand request, CancellationToken cancellationToken)
    {
        var competition = mapper.Map<Competition>(request);
        
        var existingCompetition = await competitionRepository.GetCompetitionAsync(competition.Id, cancellationToken);

        if (existingCompetition.TryPickT1(out NotFound _, out Competition _))
        {
            return new AlreadyExists();
        }
        
        return await competitionRepository.CreateCompetitionAsync(competition, cancellationToken);
    }
}
