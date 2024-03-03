using WagerWhaleApi.Application.Common.Interfaces;
using WagerWhaleApi.Infrastructure.Data;
using WagerWhaleApi.Infrastructure.Data.Interceptors;
using WagerWhaleApi.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Configuration;
using WagerWhaleApi.Domain.Competition;
using WagerWhaleApi.Domain.Constants;
using WagerWhaleApi.Domain.Repositories;
using WagerWhaleApi.Infrastructure.Data.Competitions;
using WagerWhaleApi.Infrastructure.Data.Cyclists;
using IApplicationDbContext = WagerWhaleApi.Infrastructure.Data.Common.IApplicationDbContext;

namespace Microsoft.Extensions.DependencyInjection;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("DefaultConnection");

        Guard.Against.Null(connectionString, message: "Connection string 'DefaultConnection' not found.");

        //services.AddScoped<ISaveChangesInterceptor, AuditableEntityInterceptor>();
        services.AddScoped<ISaveChangesInterceptor, DispatchDomainEventsInterceptor>();

        services.AddDbContext<ApplicationDbContext>((sp, options) =>
        {
            options.AddInterceptors(sp.GetServices<ISaveChangesInterceptor>());

            options.UseSqlServer(connectionString);
        });

        services.AddScoped<IApplicationDbContext>(provider => provider.GetRequiredService<ApplicationDbContext>());

        services.AddScoped<ApplicationDbContextInitialiser>();

        services
            .AddIdentityCore<ApplicationUser>()
            .AddRoles<IdentityRole>()
            .AddEntityFrameworkStores<ApplicationDbContext>()
            .AddApiEndpoints();

        services.AddSingleton(TimeProvider.System);
        services.AddTransient<IIdentityService, IdentityService>();

        services.AddAuthorization(options =>
            options.AddPolicy(Policies.CanPurge, policy => policy.RequireRole(Roles.Administrator)));

        return services;
    }

    public static IServiceCollection AddSqlRepositories(this IServiceCollection services)
    {
        services.AddTransient<ICompetitionRepository, CompetitionRepository>();
        services.AddTransient<ICyclistRepository, CyclistRepository>();
        return services;
    }
}
