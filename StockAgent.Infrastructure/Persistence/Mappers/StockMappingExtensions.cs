using StockAgent.Domain.Entities;
using StockAgent.Domain.ValueObjects;
using StockAgent.Infrastructure.Persistence.Models;

namespace StockAgent.Infrastructure.Persistence.Mappers
{
    public static class StockMappingExtensions
    {
        // Convert from Domain Entity to MongoDB Document Model
        public static StockModel ToMongoModel(this Stock domainStock)
        {
            return new StockModel
            {
                // Leave Id empty on new inserts so MongoDB can autogenerate it, 
                // or pass an existing technical ID tracking field if your entity tracks one.
                Symbol = domainStock.Symbol,
                CompanyName = domainStock.CompanyName,
                Exchange = domainStock.Exchange,
                Sector = domainStock.Sector,
                IsinCode = domainStock.Isin.Value, // Extracts string from your custom Value Object
                Website = domainStock.Website,
                Country = domainStock.Country,
                Currency = domainStock.Currency,
                IsActive = domainStock.IsActive
            };
        }

        // Convert from MongoDB Document Model back to pure Domain Entity
        public static Stock ToDomainEntity(this StockModel mongoModel)
        {
            if(mongoModel == null)
                throw new ArgumentNullException(nameof(mongoModel));

            // Reconstructs your clean Domain Entity using its constructor/private setters
            return new Stock(
                mongoModel.Symbol,
                mongoModel.CompanyName,
                mongoModel.Exchange,
                mongoModel.Sector,
                Isin.Create(mongoModel.IsinCode),
                mongoModel.Website,
                mongoModel.Country,
                mongoModel.Currency
            );
        }
    }

}
