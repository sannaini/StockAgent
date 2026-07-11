using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using StockAgent.Application.Contracts.Interfaces.Repositories;

namespace StockAgent.Infrastructure.Persistence
{
    public static class RepositoryServiceCollectionExtensions
    {
        public static IServiceCollection AddRepositories(
            this IServiceCollection services,
            IConfiguration configuration)
        {
           services.AddScoped<IStockRepository, StockRepository>();

            return services;
        }
    }
}
