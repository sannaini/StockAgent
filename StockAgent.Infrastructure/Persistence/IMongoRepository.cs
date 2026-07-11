using StockAgent.Infrastructure.Persistence.Models;

namespace StockAgent.Infrastructure.Persistence
{
    public interface IMongoRepository<TDocument> where TDocument : BaseModel   
    {
        Task InsertOneAsync(TDocument document, CancellationToken cancellationToken = default);

        // Additional generic operations enterprise companies use:
        Task<TDocument?> FindByIdAsync(string id, CancellationToken cancellationToken = default);
        Task DeleteByIdAsync(string id, CancellationToken cancellationToken = default);
    }
}
