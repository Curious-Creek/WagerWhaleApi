using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WagerWhaleApi.Infrastructure.Data.Common;

namespace WagerWhaleApi.Infrastructure.Data.Competitions;

public sealed class CompetitionConfiguration : BaseEntityTypeConfiguration<CompetitionEntity>
{
    public override void Configure(EntityTypeBuilder<CompetitionEntity> builder)
    {
        base.Configure(builder);

        builder.Property(x => x.Name).HasMaxLength(255).IsRequired();
        builder.Property(x => x.EntryFee).HasPrecision(6, 2).IsRequired();
        builder.Property(x => x.ConsolationPrize).HasPrecision(6, 2).HasDefaultValue(0);
        builder.Property(x => x.RewardPerStage).HasPrecision(6, 2).HasDefaultValue(0);
        builder.Property(x => x.PricePool).HasPrecision(8, 2).HasDefaultValue(0);
        builder.Property(x => x.StartDate).IsRequired();
    }
}
