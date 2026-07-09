namespace StockAgent.Application.Contracts.Models
{
    public sealed record StockProfile
    {
        public required string Symbol { get; init; }

        public required string Name { get; init; }

        public required string Country { get; init; }

        public required string Currency { get; init; }

        public required string Exchange { get; init; }

        public required string Industry { get; init; }

        public decimal MarketCap { get; init; }

        public decimal SharesOutstanding { get; init; }

        public string WebUrl { get; init; }
    }
}
