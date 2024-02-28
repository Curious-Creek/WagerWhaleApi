using AutoMapper;

namespace Blazor.Domain.Competitions;

public class CompetitionMapping : Profile
{
    public CompetitionMapping()
    {
        CreateMap<WagerWhaleApi.Domain.Entities.Competition, Competition>();
        CreateMap<Competition, CompetitionViewModel>();
        CreateMap<CompetitionViewModel, Competition>();
    }
}