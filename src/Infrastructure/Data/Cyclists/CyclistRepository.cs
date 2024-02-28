using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WagerWhaleApi.Domain.Common;
using WagerWhaleApi.Domain.Entities;
using WagerWhaleApi.Domain.Queries;
using WagerWhaleApi.Domain.Repositories;
using WagerWhaleApi.Infrastructure.Data.Common;

namespace WagerWhaleApi.Infrastructure.Data.Cyclists;

public sealed class CyclistRepository(IMapper mapper, IApplicationDbContext context) : ICyclistRepository
{
    public async Task<IReadOnlyCollection<Cyclist>> GetAllCyclistsAsync(CyclistsQuery query, CancellationToken token = default)
    {
        var queryable = context.Cyclists.AsQueryable();

        if (query.TeamId is not null)
        {
            queryable = queryable.Where(c => c.TeamId == query.TeamId);
        }

        var list = await queryable.ToListAsync(token);
        
        return mapper.Map<IReadOnlyCollection<Cyclist>>(list);
    }

    public async Task<PaginatedList<Cyclist>> GetAllCyclistsPaginatedAsync(PaginatedCyclistsQuery query, CancellationToken token = default)
    {
        var queryable = context.Cyclists.AsQueryable();
        
        if (query.TeamId is not null)
        {
            queryable = queryable.Where(c => c.TeamId == query.TeamId);
        }

        var paginatedList = await queryable.ToPaginatedListAsync(query.PageNumber, query.PageSize, token);
        
        return paginatedList.ProjectTo<CyclistEntity, Cyclist>(mapper);
    }
}
