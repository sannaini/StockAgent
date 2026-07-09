using StockAgent.Application.Contracts.Interfaces.Services;
using StockAgent.Domain.ValueObjects;

namespace StockAgent.Worker.Ingestion
{
    public sealed class StockPriceIngestionWorker(
        IServiceScopeFactory scopeFactory,
        ILogger<StockPriceIngestionWorker> logger)
        : BackgroundService
    {
        private readonly ILogger<StockPriceIngestionWorker> _logger = logger;


        protected override async Task ExecuteAsync(
            CancellationToken stoppingToken)
        {
            using var scope = scopeFactory.CreateScope();

            var ingestionService = scope
                .ServiceProvider
                .GetRequiredService<IStockIngestionService>();

            await ingestionService.IngestStocksAsync([Isin.Create("US5949181045")], stoppingToken);
        }
    }
}
