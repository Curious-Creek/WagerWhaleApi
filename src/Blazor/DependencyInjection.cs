using Blazor.Adapters.Competitions;

namespace Blazor;

public static class DependencyInjection
{
    public static IServiceCollection AddBlazorServices(this IServiceCollection services)
    {
        services.AddTransient<ICompetitionsAdapter, CompetitionsAdapter>();
        return services;
    }
}
