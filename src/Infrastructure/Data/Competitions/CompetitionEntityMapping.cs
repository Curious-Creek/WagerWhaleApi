using AutoMapper;
using WagerWhaleApi.Domain.Competition;

namespace WagerWhaleApi.Infrastructure.Data.Competitions;

public class CompetitionEntityMapping : Profile
{
    public CompetitionEntityMapping()
    {
        CreateMap<Competition, CompetitionEntity>();
        CreateMap<CompetitionEntity, Competition>();
    }
}
