using AutoMapper;
using Blazor.Domain.Competitions;
using MediatR;
using OneOf;
using WagerWhaleApi.Application.Competitions.Commands.CreateCompetition;
using WagerWhaleApi.Application.Competitions.Queries.GetCompetitions;
using WagerWhaleApi.Domain.Common;

namespace Blazor.Adapters.Competitions;

public sealed class CompetitionsAdapter(ISender sender, IMapper mapper) : ICompetitionsAdapter
{
    public async Task<OneOf<Competition, AlreadyExists>> CreateCompetitionAsync(CreateCompetition createCompetition)
    {
        var createCompetitionCommand = mapper.Map<CreateCompetitionCommand>(createCompetition);
        var result = await sender.Send(createCompetitionCommand);
        return result.Match<OneOf<Competition, AlreadyExists>>(
            competition => mapper.Map<Competition>(createCompetition),
            _ => new AlreadyExists());
    }

    public async Task<IReadOnlyCollection<Competition>> GetCompetitionsAsync()
    {
        var result = await sender.Send(new GetCompetitionsQuery());
        return mapper.Map<IReadOnlyCollection<Competition>>(result);
    }
}
