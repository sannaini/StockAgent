using StockAgent.Domain.ValueObjects;

namespace StockAgent.Application.Contracts.Interfaces.Services
{
    public interface IStockIngestionService
    {
        Task IngestStocksAsync(IEnumerable<Isin> isins, CancellationToken cancellationToken);
    }
}
