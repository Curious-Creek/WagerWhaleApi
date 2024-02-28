using AutoMapper;

namespace WagerWhaleApi.Infrastructure.Data.Competitions;

public class CompetitionEntityMapping : Profile
{
    public CompetitionEntityMapping()
    {
        CreateMap<Domain.Entities.Competition, CompetitionEntity>();
        CreateMap<CompetitionEntity, Domain.Entities.Competition>();
    }
}
