using MongoDB.Driver;
using StockAgent.Application.Contracts.Interfaces.Repositories;
using StockAgent.Domain.Entities;
using StockAgent.Infrastructure.Persistence.Mappers;
using StockAgent.Infrastructure.Persistence.Models;

namespace StockAgent.Infrastructure.Persistence
{
    public class StockRepository(IMongoDatabase database) : MongoRepository<StockModel>(database), IStockRepository
    {
        async Task IStockRepository.AddAsync(Stock stock, CancellationToken cancellationToken = default)
        {
          await base.InsertOneAsync(stock.ToMongoModel(), cancellationToken);
        }
    }
}

