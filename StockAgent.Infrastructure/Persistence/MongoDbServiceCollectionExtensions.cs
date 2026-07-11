using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace StockAgent.Infrastructure.Persistence
{
    public static class MongoDbServiceCollectionExtensions
    {
        public static IServiceCollection AddMongoDb(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            services.Configure<MongoDbOptions>(
                configuration.GetSection(MongoDbOptions.SectionName));

            services.AddSingleton<IMongoClient>(sp =>
            {
                var settings = sp.GetRequiredService<IOptions<MongoDbOptions>>().Value;
                return new MongoClient(settings.ConnectionString);
            });

            services.AddScoped<IMongoDatabase>(sp =>
            {
                var client = sp.GetRequiredService<IMongoClient>();
                var settings = sp.GetRequiredService<IOptions<MongoDbOptions>>().Value;
                return client.GetDatabase(settings.DatabaseName);
            });

            return services;
        }
    }
}
