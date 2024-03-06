using Microsoft.EntityFrameworkCore;
using WagerWhaleApi.Domain.Entities;
using WagerWhaleApi.Infrastructure.Data.CompetitionParticipants;
using WagerWhaleApi.Infrastructure.Data.Competitions;
using WagerWhaleApi.Infrastructure.Data.Cyclists;
using WagerWhaleApi.Infrastructure.Data.CyclistTeams;
using WagerWhaleApi.Infrastructure.Data.Stages;

namespace WagerWhaleApi.Infrastructure.Data.Common;

public interface IApplicationDbContext
{
    DbSet<CompetitionEntity> Competitions { get; }
    public DbSet<CompetitionParticipantEntity> CompetitionParticipants { get; }
    DbSet<CyclistEntity> Cyclists { get; }
    public DbSet<CyclistTeamEntity> CyclistTeams { get; }
    public DbSet<StageEntity> Stages { get; }
    
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
