namespace WagerWhaleApi.Domain.Queries;

public sealed record PaginatedCyclistsQuery(Guid? TeamId, int PageNumber, int PageSize) : PaginationQuery(PageNumber, PageSize);
