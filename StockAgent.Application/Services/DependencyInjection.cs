using Microsoft.Extensions.DependencyInjection;
using StockAgent.Application.Contracts.Interfaces.Services;

namespace StockAgent.Application.Services
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(
            this IServiceCollection services)
        {
            services.AddScoped<IStockIngestionService, StockIngestionService>();

            return services;
        }
    }
}
