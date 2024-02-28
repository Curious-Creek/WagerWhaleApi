﻿namespace WagerWhaleApi.Domain.Common;

public class PaginatedList<T>(IReadOnlyCollection<T> items, int count, int pageNumber, int pageSize)
{
    public IReadOnlyCollection<T> Items { get; } = items;
    public int PageNumber { get; } = pageNumber;
    public int TotalPages { get; } = (int)Math.Ceiling(count / (double)pageSize);
    public int TotalCount { get; } = count;

    public int PageSize { get; } = pageSize;

    public bool HasPreviousPage => PageNumber > 1;

    public bool HasNextPage => PageNumber < TotalPages;
}