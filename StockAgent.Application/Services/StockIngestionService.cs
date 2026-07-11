using StockAgent.Application.Contracts.Interfaces.Clients;
using StockAgent.Application.Contracts.Interfaces.Repositories;
using StockAgent.Application.Contracts.Interfaces.Services;
using StockAgent.Domain.Entities;
using StockAgent.Domain.ValueObjects;

namespace StockAgent.Application.Services
{
    public class StockIngestionService(IStockApiClient stockApiClient,
        IStockRepository stockRepository) : IStockIngestionService
    {
        public async Task IngestStocksAsync(IEnumerable<Isin> isins, CancellationToken cancellationToken)
        {
            var stockDetailsTask = await stockApiClient.GetStockDetailsAsync(isins.First(), cancellationToken);

            if (stockDetailsTask is null)
                return;

            var stock = new Stock(
                stockDetailsTask.Symbol,
                stockDetailsTask.Name,
                stockDetailsTask.Exchange,
                stockDetailsTask.Sector,
                stockDetailsTask.Isin,
                stockDetailsTask.WebUrl,
                stockDetailsTask.Country,
                stockDetailsTask.Currency
            );

            await stockRepository.AddAsync(stock, cancellationToken);
        }
    }
}
