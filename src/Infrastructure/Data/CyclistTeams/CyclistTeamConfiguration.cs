using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WagerWhaleApi.Infrastructure.Data.Common;

namespace WagerWhaleApi.Infrastructure.Data.CyclistTeams;

public class CyclistTeamConfiguration : BaseEntityTypeConfiguration<CyclistTeamEntity>
{
    public override void Configure(EntityTypeBuilder<CyclistTeamEntity> builder)
    {
        base.Configure(builder);
        builder.ToTable("CyclistTeams");
        builder.Property(x => x.Name).HasMaxLength(510).IsRequired();
        builder.Property(x => x.CountryName).HasMaxLength(255).IsRequired();
    }
}
