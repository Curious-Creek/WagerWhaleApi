using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WagerWhaleApi.Infrastructure.Data.Common;
using WagerWhaleApi.Infrastructure.Data.Competitions;
using WagerWhaleApi.Infrastructure.Data.Users;

namespace WagerWhaleApi.Infrastructure.Data.CompetitionParticipants;
public sealed class CompetitionParticipantConfiguration : BaseEntityTypeConfiguration<CompetitionParticipantEntity>
{
    public override void Configure(EntityTypeBuilder<CompetitionParticipantEntity> builder)
    {
        base.Configure(builder);

        builder.HasOne<UserEntity>()
            .WithMany()
            .HasForeignKey(x => x.UserId)
            .HasPrincipalKey(x => x.DomainId);

        builder.HasOne<CompetitionEntity>()
            .WithMany()
            .HasForeignKey(x => x.CompetitionId)
            .HasPrincipalKey(x => x.DomainId);
    }
}
