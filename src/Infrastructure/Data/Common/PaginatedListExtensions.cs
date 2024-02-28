using AutoMapper;
using WagerWhaleApi.Domain.Common;

namespace WagerWhaleApi.Infrastructure.Data.Common;

public static class PaginatedListExtensions
{
    public static PaginatedList<TDestination> ProjectTo<TSource, TDestination>(this PaginatedList<TSource> source, IMapper mapper)
    {
        return new PaginatedList<TDestination>(mapper.Map<IReadOnlyCollection<TDestination>>(source.Items),
            source.TotalCount, source.PageNumber, source.PageSize);
    }
}
