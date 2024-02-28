using Microsoft.EntityFrameworkCore;
using WagerWhaleApi.Domain.Entities;
using WagerWhaleApi.Infrastructure.Data.Competitions;
using WagerWhaleApi.Infrastructure.Data.Cyclists;

namespace WagerWhaleApi.Infrastructure.Data.Common;

public interface IApplicationDbContext : Application.Common.Interfaces.IApplicationDbContext
{
    DbSet<TodoList> TodoLists { get; }

    DbSet<TodoItem> TodoItems { get; }
    DbSet<CompetitionEntity> Competitions { get; }
    DbSet<CyclistEntity> Cyclists { get; }
}
