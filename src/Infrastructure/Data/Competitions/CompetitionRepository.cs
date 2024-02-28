using AutoMapper;
using Microsoft.EntityFrameworkCore;
using OneOf;
using WagerWhaleApi.Domain.Common;
using WagerWhaleApi.Domain.Entities;
using WagerWhaleApi.Domain.Repositories;
using WagerWhaleApi.Infrastructure.Data.Common;

namespace WagerWhaleApi.Infrastructure.Data.Competitions;

public sealed class CompetitionRepository(IMapper mapper, IApplicationDbContext context) : ICompetitionRepository
{
    public async Task<Guid> CreateCompetitionAsync(Competition competition, CancellationToken token = default)
    {
        var competitionEntity = mapper.Map<CompetitionEntity>(competition);
        context.Competitions.Add(competitionEntity);
        await context.SaveChangesAsync(token);
        return competitionEntity.DomainId;
    }

    public async Task<OneOf<Competition, NotFound>> GetCompetitionAsync(Guid competitionId, CancellationToken token = default)
    {
        var competitionEntity = await context.Competitions.FindAsync([competitionId], token);

        if (competitionEntity == null)
        {
            return new NotFound();
        }

        return mapper.Map<Competition>(competitionEntity);
    }

    public async Task<IReadOnlyCollection<Competition>> GetAllCompetitionsAsync(CancellationToken token = default)
    {
        var competitions = await context.Competitions.ToListAsync(token);
        return mapper.Map<IReadOnlyCollection<Competition>>(competitions.AsReadOnly());
    }
}
