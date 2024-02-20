using WagerWhaleApi.Infrastructure.Data.Common;

namespace WagerWhaleApi.Infrastructure.Data.CyclistTeams;

public class CyclistTeamEntity : BaseEntity
{
    public string Name { get; set; } = default!;
    public string CountryName { get; set; } = default!;
}
