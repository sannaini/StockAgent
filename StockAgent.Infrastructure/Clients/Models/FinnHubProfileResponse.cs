namespace StockAgent.Infrastructure.Clients.Models
{
    using System.Text.Json.Serialization;

    public sealed class FinnHubProfileResponse
    {
        [JsonPropertyName("ticker")]
        public string Ticker { get; init; } = string.Empty;

        [JsonPropertyName("name")]
        public string Name { get; init; } = string.Empty;

        [JsonPropertyName("country")]
        public string Country { get; init; } = string.Empty;

        [JsonPropertyName("currency")]
        public string Currency { get; init; } = string.Empty;

        [JsonPropertyName("exchange")]
        public string Exchange { get; init; } = string.Empty;

        [JsonPropertyName("ipo")]
        public DateOnly? Ipo { get; init; }

        [JsonPropertyName("marketCapitalization")]
        public decimal MarketCapitalization { get; init; }

        [JsonPropertyName("shareOutstanding")]
        public decimal ShareOutstanding { get; init; }

        [JsonPropertyName("finnhubIndustry")]
        public string FinnhubIndustry { get; init; } = string.Empty;

        [JsonPropertyName("weburl")]
        public string WebUrl { get; init; } = string.Empty;

        [JsonPropertyName("logo")]
        public string Logo { get; init; } = string.Empty;

        [JsonPropertyName("floatingShare")]
        public decimal FloatingShare { get; init; }
    }
}
