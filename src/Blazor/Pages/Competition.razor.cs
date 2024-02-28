using Blazor.Adapters.Competitions;
using Blazor.Domain.Competitions;
using Microsoft.AspNetCore.Components;

namespace Blazor.Pages;

public partial class Competition
{
    public List<CompetitionViewModel> CompetitionViewModels { get; set; }

    [Inject] 
    public ICompetitionsAdapter CompetitionsAdapter { get; set; } = default!;

    public Competition()
    {
        CompetitionViewModels = new List<CompetitionViewModel>();
    }

    protected async override Task OnInitializedAsync()
    {
        var competitions = await CompetitionsAdapter.GetCompetitionsAsync();
        CompetitionViewModels = competitions.Select(c => new CompetitionViewModel(c)).ToList();
    }

    public async Task CreateCompetition()
    {
        var result = await CompetitionsAdapter.CreateCompetitionAsync(new CreateCompetition("Test", 10, new DateOnly(2022, 1, 1)));
    }
}
