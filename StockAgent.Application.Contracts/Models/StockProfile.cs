using StockAgent.Domain.Enums;
using StockAgent.Domain.ValueObjects;

namespace StockAgent.Application.Contracts.Models
{
    public sealed record StockProfile
    {
        public required string Symbol { get; init; }

        public required string Name { get; init; }

        public required string Country { get; init; }

        public required string Currency { get; init; }

        public required string Exchange { get; init; }

        public Sector Sector { get; private set; }

        public Isin Isin { get; private set; }

        public decimal MarketCap { get; init; }

        public decimal SharesOutstanding { get; init; }

        public string WebUrl { get; init; }

        public void SetIsin(string isin)
        {
            Isin = Isin.Create(isin);
        }

    }
}
