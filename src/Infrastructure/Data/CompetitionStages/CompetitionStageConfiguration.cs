using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WagerWhaleApi.Infrastructure.Data.Competitions;
using WagerWhaleApi.Infrastructure.Data.Stages;

namespace WagerWhaleApi.Infrastructure.Data.CompetitionStages;

public sealed class CompetitionStageConfiguration : IEntityTypeConfiguration<CompetitionStageEntity>
{
    public void Configure(EntityTypeBuilder<CompetitionStageEntity> builder)
    {
        builder.ToTable("CompetitionStages");
        builder.HasNoKey();

        builder.HasOne<StageEntity>()
            .WithMany()
            .HasForeignKey(x => x.StageId)
            .HasPrincipalKey(x => x.DomainId)
            .IsRequired();

        builder.HasOne<CompetitionEntity>()
            .WithMany()
            .HasForeignKey(x => x.CompetitionId)
            .HasPrincipalKey(x => x.DomainId)
            .IsRequired();
    }
}
