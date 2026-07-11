using StockAgent.Domain.Entities;

namespace StockAgent.Application.Contracts.Interfaces.Repositories
{
    public interface IStockRepository
    {
        Task AddAsync(Stock stock, CancellationToken cancellationToken = default);
    }
}
