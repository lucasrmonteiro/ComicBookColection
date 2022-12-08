namespace ComicBookCollection.IoC;

using ComicBookCollection.Business;
using ComicBookCollection.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

public static class Bootstrap
{
    public static IServiceCollection ConfigureDI(this IServiceCollection services)
    {
        services.AddScoped<IComicsRepository, ComicsRepository>();
        services.AddScoped<IComicsService, ComicsService>();

        return services;
    }
}