using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WagerWhaleApi.Infrastructure.Data.Common;
using WagerWhaleApi.Infrastructure.Data.CyclistTeams;

namespace WagerWhaleApi.Infrastructure.Data.Cyclists;

public class CyclistConfiguration : BaseEntityTypeConfiguration<CyclistEntity>
{
    public override void Configure(EntityTypeBuilder<CyclistEntity> builder)
    {
        base.Configure(builder);

        builder.ToTable("Cyclists");

        builder.Property(c => c.FirstName).IsRequired().HasMaxLength(255);
        builder.Property(c => c.LastName).IsRequired().HasMaxLength(255);
        builder.Property(c => c.DateOfBirth).IsRequired();

        builder.HasOne<CyclistTeamEntity>()
            .WithMany()
            .HasForeignKey(x => x.TeamId)
            .HasPrincipalKey(x => x.DomainId)
            .IsRequired();
    }
}
