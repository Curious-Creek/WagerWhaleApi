using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WagerWhaleApi.Infrastructure.Data.Cyclists;
using WagerWhaleApi.Infrastructure.Data.ParticipantTeams;

namespace WagerWhaleApi.Infrastructure.Data.CyclistParticipantTeams;

public sealed class CyclistParticipantTeamConfiguration : IEntityTypeConfiguration<CyclistParticipantTeamEntity>
{
    public void Configure(EntityTypeBuilder<CyclistParticipantTeamEntity> builder)
    {
        builder.ToTable("CyclistParticipantTeams");
        builder.HasNoKey();
        
        builder.HasOne<CyclistEntity>()
            .WithMany()
            .HasForeignKey(x => x.CyclistId)
            .HasPrincipalKey(x => x.DomainId)
            .IsRequired();

        builder.HasOne<ParticipantTeamEntity>()
            .WithMany()
            .HasForeignKey(x => x.ParticipantTeamId)
            .HasPrincipalKey(x => x.DomainId)
            .IsRequired();
    }
}
