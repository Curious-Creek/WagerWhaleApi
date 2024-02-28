namespace WagerWhaleApi.Application.Competitions.Commands.CreateCompetition;

public class CreateCompetitionValidator : AbstractValidator<CreateCompetitionCommand>
{
    public CreateCompetitionValidator()
    {
        RuleFor(v => v.Name).MaximumLength(255).NotEmpty();
        RuleFor(v => v.EntryFee).LessThan(1000).NotEmpty();
        RuleFor(v => v.StartDate).NotEmpty();
    }
}
