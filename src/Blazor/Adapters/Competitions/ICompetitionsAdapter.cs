using Blazor.Domain.Competitions;
using WagerWhaleApi.Domain.Common;
using OneOf;

namespace Blazor.Adapters.Competitions;

public interface ICompetitionsAdapter
{
    public Task<OneOf<Competition, AlreadyExists>> CreateCompetitionAsync(CreateCompetition createCompetition);
    
    public Task<IReadOnlyCollection<Competition>> GetCompetitionsAsync();
}
