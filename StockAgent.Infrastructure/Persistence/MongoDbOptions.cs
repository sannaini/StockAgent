using System;
using System.Collections.Generic;
using System.Text;

namespace StockAgent.Infrastructure.Persistence
{
    public class MongoDbOptions
    {

        public const string SectionName = "MongoDb";
        public string ConnectionString { get; set; } = string.Empty;
        public string DatabaseName { get; set; } = string.Empty;
    }
}
