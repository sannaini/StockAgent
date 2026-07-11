using System;
using System.Collections.Generic;
using System.Text;

namespace StockAgent.Infrastructure.Persistence
{
    [AttributeUsage(AttributeTargets.Class)]
    public class BsonCollectionAttribute : Attribute
    {
        public string CollectionName { get; }
        public BsonCollectionAttribute(string collectionName) => CollectionName = collectionName;
    }
}
