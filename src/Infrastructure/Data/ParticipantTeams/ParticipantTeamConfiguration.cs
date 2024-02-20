using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WagerWhaleApi.Infrastructure.Data.Common;
using WagerWhaleApi.Infrastructure.Data.CompetitionParticipants;

namespace WagerWhaleApi.Infrastructure.Data.ParticipantTeams;
public class ParticipantTeamConfiguration : BaseEntityTypeConfiguration<ParticipantTeamEntity>
{
    public override void Configure(EntityTypeBuilder<ParticipantTeamEntity> builder)
    {
        base.Configure(builder);
        builder.ToTable("ParticipantTeams");

        builder.HasOne<CompetitionParticipantEntity>()
            .WithOne()
            .HasForeignKey<ParticipantTeamEntity>(x => x.ParticipantId)
            .HasPrincipalKey<CompetitionParticipantEntity>(x => x.DomainId)
            .IsRequired();
    }
}
