namespace Blazor.Domain.Competitions;

public record CreateCompetition(string Name, decimal EntryFee, DateOnly StartDate);
