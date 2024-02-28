using System.Reflection;
using WagerWhaleApi.Domain.Entities;
using WagerWhaleApi.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WagerWhaleApi.Infrastructure.Data.Competitions;
using WagerWhaleApi.Infrastructure.Data.Cyclists;
using IApplicationDbContext = WagerWhaleApi.Infrastructure.Data.Common.IApplicationDbContext;

namespace WagerWhaleApi.Infrastructure.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : IdentityDbContext<ApplicationUser>(options), IApplicationDbContext
{
    public DbSet<TodoList> TodoLists => Set<TodoList>();
    public DbSet<TodoItem> TodoItems => Set<TodoItem>();
    public DbSet<CompetitionEntity> Competitions => Set<CompetitionEntity>();
    public DbSet<CyclistEntity> Cyclists => Set<CyclistEntity>();

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
