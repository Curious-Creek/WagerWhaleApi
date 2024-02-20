using WagerWhaleApi.Infrastructure.Data.Common;

namespace WagerWhaleApi.Infrastructure.Data.CompetitionParticipants;

public sealed class CompetitionParticipantEntity : BaseEntity
{
    public Guid CompetitionId { get; set; }
    public Guid UserId { get; set; }
    public bool HasPaid { get; set; }
    public int TotalScore { get; set; }
}
