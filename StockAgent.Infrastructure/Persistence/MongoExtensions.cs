namespace StockAgent.Infrastructure.Persistence
{
    public static class MongoExtensions
    {
        public static string GetCollectionName<T>()
        {
            return (typeof(T).GetCustomAttributes(typeof(BsonCollectionAttribute), true)
                       .FirstOrDefault() as BsonCollectionAttribute)?.CollectionName
                   ?? typeof(T).Name.ToLower(); // Fallback
        }
    }
}
