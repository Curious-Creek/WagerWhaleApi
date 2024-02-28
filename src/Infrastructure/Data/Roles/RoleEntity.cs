using WagerWhaleApi.Infrastructure.Data.Common;

namespace WagerWhaleApi.Infrastructure.Data.Roles;

public class RoleEntity : BaseEntity
{
    public string Name { get; set; } = default!;
}
