using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WagerWhaleApi.Infrastructure.Data.Common;

namespace WagerWhaleApi.Infrastructure.Data.Roles;

public class RoleConfiguration : BaseEntityTypeConfiguration<RoleEntity>
{
    public override void Configure(EntityTypeBuilder<RoleEntity> builder)
    {
        base.Configure(builder);
        builder.ToTable("Roles");
        builder.Property(c => c.Name).IsRequired().HasMaxLength(50);
    }
}
