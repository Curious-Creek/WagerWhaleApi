using WagerWhaleApi.Application.Competitions.Queries.GetCompetitions;
using WagerWhaleApi.Domain.Competition;

namespace WagerWhaleApi.Web.Endpoints;

public class Competitions : EndpointGroupBase
{
    public override void Map(WebApplication app)
    {
        app.MapGroup(this)
            .MapGet(GetCompetitionsAsync);
    }
    
    public Task<IReadOnlyCollection<Competition>> GetCompetitionsAsync(ISender sender)
    {
        return sender.Send(new GetCompetitionsQuery());
    }
}
