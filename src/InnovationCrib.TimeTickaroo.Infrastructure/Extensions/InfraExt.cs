using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace InnovationCrib.TimeTickaroo.Infrastructure.Extensions;
public static class InfraExt
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        var defaultConnectionString = configuration.GetConnectionString("Default");
        services.Configure<DbOptions>(o => o.DefaultConnectionString = defaultConnectionString );
        services.AddDbContext<TimeTickarooContext>();
        return services;
    }
    
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, string defaultConnectionString)
   
    {
    
        services.Configure<DbOptions>(o => o.DefaultConnectionString = defaultConnectionString );
        services.AddDbContext<TimeTickarooContext>();
        return services;
    }
}