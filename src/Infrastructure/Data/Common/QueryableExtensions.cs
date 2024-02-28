using Microsoft.EntityFrameworkCore;
using WagerWhaleApi.Domain.Common;

namespace WagerWhaleApi.Infrastructure.Data.Common;

public static class QueryableExtensions
{
    public static async Task<PaginatedList<T>> ToPaginatedListAsync<T>(this IQueryable<T> source, int pageNumber, int pageSize, CancellationToken token = default) where T : class
    {
        var count = await source.CountAsync(token);
        var items = await source.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToListAsync(token);

        return new PaginatedList<T>(items, count, pageNumber, pageSize);
    }
}
