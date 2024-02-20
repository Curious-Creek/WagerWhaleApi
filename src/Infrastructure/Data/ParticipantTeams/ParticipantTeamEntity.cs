using WagerWhaleApi.Infrastructure.Data.Common;

namespace WagerWhaleApi.Infrastructure.Data.ParticipantTeams;

public sealed class ParticipantTeamEntity : BaseEntity
{
    public Guid ParticipantId { get; set; }
}
