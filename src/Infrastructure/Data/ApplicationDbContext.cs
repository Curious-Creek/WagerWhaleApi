using System.Reflection;
using WagerWhaleApi.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WagerWhaleApi.Infrastructure.Data.Common;
using WagerWhaleApi.Infrastructure.Data.CompetitionParticipants;
using WagerWhaleApi.Infrastructure.Data.Competitions;
using WagerWhaleApi.Infrastructure.Data.Cyclists;
using WagerWhaleApi.Infrastructure.Data.CyclistTeams;
using WagerWhaleApi.Infrastructure.Data.Stages;

namespace WagerWhaleApi.Infrastructure.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : IdentityDbContext<ApplicationUser>(options), IApplicationDbContext
{
    public DbSet<CompetitionEntity> Competitions => Set<CompetitionEntity>();
    public DbSet<CompetitionParticipantEntity> CompetitionParticipants => Set<CompetitionParticipantEntity>();
    public DbSet<CyclistEntity> Cyclists => Set<CyclistEntity>();
    public DbSet<CyclistTeamEntity> CyclistTeams => Set<CyclistTeamEntity>();
    public DbSet<StageEntity> Stages => Set<StageEntity>();

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
