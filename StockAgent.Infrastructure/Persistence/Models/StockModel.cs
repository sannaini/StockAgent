using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using StockAgent.Domain.Enums;

namespace StockAgent.Infrastructure.Persistence.Models
{
    [BsonCollection("stocks")]
    public class StockModel : BaseModel
    {
        [BsonElement("symbol")]
        public string Symbol { get; set; } = string.Empty;

        [BsonElement("companyName")]
        public string CompanyName { get; set; } = string.Empty;

        [BsonElement("exchange")]
        public string Exchange { get; set; } = string.Empty;

        // Stores the Enum as a readable string (e.g., "Technology") instead of an integer
        [BsonElement("sector")]
        [BsonRepresentation(BsonType.String)]
        public Sector Sector { get; set; }

        // Flattens your custom Isin value object down to a primitive string for clear database querying
        [BsonElement("isin")]
        public string IsinCode { get; set; } = string.Empty;

        [BsonElement("website")]
        public string Website { get; set; } = string.Empty;

        [BsonElement("country")]
        public string Country { get; set; } = string.Empty;

        [BsonElement("currency")]
        public string Currency { get; set; } = string.Empty;

        [BsonElement("isActive")]
        public bool IsActive { get; set; }
    }

}
