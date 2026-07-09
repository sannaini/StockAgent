using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace StockAgent.Infrastructure.Mappers
{
    public  static class MappersDependencyInjection
    {
        public static IServiceCollection AddMappers(
            this IServiceCollection services,
            IConfiguration configuration)
        {
           services.AddSingleton<FinnHubProfileMapper>();
            return services;
        }
    }
}
