using WagerWhaleApi.Infrastructure.Data.Common;

namespace WagerWhaleApi.Infrastructure.Data.Users;

public sealed class UserEntity : BaseEntity
{
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
    public string DisplayName { get; set; } = default!;
}
