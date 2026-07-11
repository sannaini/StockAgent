using MongoDB.Driver;
using StockAgent.Infrastructure.Persistence.Models;

namespace StockAgent.Infrastructure.Persistence
{
    public class MongoRepository<TDocument> : IMongoRepository<TDocument> where TDocument : BaseModel
    {
        protected readonly IMongoCollection<TDocument> _collection;

        public MongoRepository(IMongoDatabase database)
        {
            var collectionName = MongoExtensions.GetCollectionName<TDocument>();
            _collection = database.GetCollection<TDocument>(collectionName);
        }

        public async Task InsertOneAsync(TDocument document, CancellationToken cancellationToken = default)
        {
            await _collection.InsertOneAsync(document, cancellationToken: cancellationToken);
        }

        public Task<TDocument?> FindByIdAsync(string id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task DeleteByIdAsync(string id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
