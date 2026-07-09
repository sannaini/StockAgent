

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using StockAgent.Application.Contracts.Interfaces.Clients;
namespace StockAgent.Infrastructure.Clients.Services
{
    public static class FinnHubServiceCollectionExtenstion
    {
        public static IServiceCollection AddFinnHub(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            services.Configure<FinnHubOptions>(
                configuration.GetSection(FinnHubOptions.SectionName));

            services.AddHttpClient<IStockApiClient, FinnHubClient>((sp, client) =>
            {
                var options = sp.GetRequiredService<IOptions<FinnHubOptions>>().Value;

                client.BaseAddress = new Uri(options.BaseUrl);
                client.DefaultRequestHeaders.Add("Accept", "application/json");
                client.DefaultRequestHeaders.Add("X-Finnhub-Token", options.ApiKey);
            });

            return services;
        }
    }
}
