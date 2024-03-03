using Microsoft.Extensions.Logging;
using WagerWhaleApi.Domain.Competition;

namespace WagerWhaleApi.Application.Competitions.EventHandlers;

public class CompetitionCreatedEventHandler(ILogger<CompetitionCreatedEventHandler> Logger) : INotificationHandler<CompetitionCreatedEvent>
{
    public Task Handle(CompetitionCreatedEvent notification, CancellationToken cancellationToken)
    {
        Logger.LogInformation("Competition created: {Competition}", notification.Competition);
        return Task.CompletedTask;
    }
}
