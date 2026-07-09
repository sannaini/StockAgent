using StockAgent.Application.Contracts.Interfaces.Clients;
using StockAgent.Application.Contracts.Interfaces.Services;
using StockAgent.Domain.ValueObjects;

namespace StockAgent.Application.Services
{
    public class StockIngestionService(IStockApiClient stockApiClient) : IStockIngestionService
    {
        public async Task IngestStocksAsync(IEnumerable<Isin> isins, CancellationToken cancellationToken)
        {
            var stockDetailsTask = await stockApiClient.GetStockDetailsAsync(isins.First(), cancellationToken);

            // TODO: map to stock

            // save to database


        }
    }
}
