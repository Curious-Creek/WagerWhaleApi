using WagerWhaleApi.Domain.Common;
using WagerWhaleApi.Domain.Entities;
using WagerWhaleApi.Domain.Queries;
using WagerWhaleApi.Domain.Repositories;

namespace WagerWhaleApi.Application.Cyclists.Queries.GetCyclistsWithPagination;

public record GetCyclistsWithPaginationQuery : IRequest<PaginatedList<Cyclist>>
{
    public int PageNumber { get; set; }
    public int PageSize { get; set; }
    public Guid TeamId { get; set; }

    private class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<GetCyclistsWithPaginationQuery, PaginatedCyclistsQuery>();
        }
    }
}

public sealed class GetCyclistsWithPaginationQueryHandler(IMapper mapper, ICyclistRepository cyclistRepository)
    : IRequestHandler<GetCyclistsWithPaginationQuery, PaginatedList<Cyclist>>
{
    public async Task<PaginatedList<Cyclist>> Handle(GetCyclistsWithPaginationQuery request, CancellationToken cancellationToken)
    {
        return await cyclistRepository.GetAllCyclistsPaginatedAsync(mapper.Map<PaginatedCyclistsQuery>(request), cancellationToken);
    }
}
