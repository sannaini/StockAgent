using StockAgent.Domain.Enums;
using StockAgent.Domain.ValueObjects;

namespace StockAgent.Domain.Entities
{
    public class Stock
    {
        public string Symbol { get; }
        public string CompanyName { get; private set; }
        public string Exchange { get; private set; }

        public Sector Sector { get; private set; }
        public Industry Industry { get; private set; }

        public Isin Isin { get; private set; }

        public string Description { get; private set; }
        public string Website { get; private set; }

        public string Country { get; private set; }
        public string Currency { get; private set; }
        public bool IsActive { get; private set; }

        public Stock(
            string symbol,
            string companyName,
            string exchange,
            Sector sector,
            Isin isin,
            Industry industry)
        {
            Symbol = symbol.ToUpperInvariant();
            CompanyName = companyName;
            Exchange = exchange;
            Sector = sector;
            Industry = industry;
            Isin = isin;

            IsActive = true;
        }

        public void ChangeCompanyName(string companyName)
        {
            CompanyName = companyName;
        }

        public void ChangeSector(Sector sector)
        {
            Sector = sector;
        }

        public void ChangeIndustry(Industry industry)
        {
            Industry = industry;
        }

        public void Deactivate()
        {
            IsActive = false;
        }

        public void Activate()
        {
            IsActive = true;
        }
    }
}
