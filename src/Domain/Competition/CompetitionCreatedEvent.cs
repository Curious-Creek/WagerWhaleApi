namespace WagerWhaleApi.Domain.Competition;

public class CompetitionCreatedEvent(Competition competition) : BaseEvent
{
    public Competition Competition { get; } = competition;
}
