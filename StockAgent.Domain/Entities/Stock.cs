using StockAgent.Domain.Enums;
using StockAgent.Domain.ValueObjects;

namespace StockAgent.Domain.Entities
{
    public class Stock
    {
        public string Symbol { get; private set; }
        public string CompanyName { get; private set; }
        public string Exchange { get; private set; }

        public Sector Sector { get; private set; }

        public Isin Isin { get; private set; }

        public string Website { get; private set; }
        public string Country { get; private set; }
        public string Currency { get; private set; }

        public bool IsActive { get; private set; }


        private Stock()
        {
           
        }


        public Stock(string symbol,
            string companyName,
            string exchange,
            Sector sector,
            Isin isin,
            string country,
            string currency,
            string website)
        {
            Symbol = symbol.ToUpperInvariant();
            CompanyName = companyName;
            Exchange = exchange;
            Sector = sector;
            Isin = isin;
            Country = country;
            Currency = currency;
            Website = website;
            IsActive = true;
        }
    }
}
