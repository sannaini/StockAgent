using StockAgent.Application.Contracts.Models;
using StockAgent.Domain.ValueObjects;

namespace StockAgent.Application.Contracts.Interfaces.Clients
{
    public interface IStockApiClient
    {
        Task<StockProfile?> GetStockDetailsAsync(
            Isin isin,
            CancellationToken cancellationToken = default);
    }
}
