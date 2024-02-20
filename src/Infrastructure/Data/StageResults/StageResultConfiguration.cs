using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WagerWhaleApi.Infrastructure.Data.Cyclists;
using WagerWhaleApi.Infrastructure.Data.Stages;

namespace WagerWhaleApi.Infrastructure.Data.StageResults;

public class StageResultConfiguration : IEntityTypeConfiguration<StageResultEntity>
{
    public void Configure(EntityTypeBuilder<StageResultEntity> builder)
    {
        builder.ToTable("StageResults");
        // Test generation. If the default behaviour is to create an Id column then add this line below to create primary key based on the CyclistId and StageId
        //builder.HasKey(x => new { x.CyclistId, x.StageId });

        builder.HasOne<CyclistEntity>()
            .WithMany()
            .HasForeignKey(x => x.CyclistId)
            .HasPrincipalKey(x => x.DomainId)
            .IsRequired();

        builder.HasOne<StageEntity>()
            .WithMany()
            .HasForeignKey(x => x.StageId)
            .HasPrincipalKey(x => x.DomainId)
            .IsRequired();
    }
}
