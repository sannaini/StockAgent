using System;
using System.Collections.Generic;
using System.Text;

namespace StockAgent.Infrastructure.Clients
{
    public sealed class FinnHubOptions
    {
        public const string SectionName = "FinnHub";

        public string BaseUrl { get; init; } = string.Empty;

        public string ApiKey { get; init; } = string.Empty;
    }
}
