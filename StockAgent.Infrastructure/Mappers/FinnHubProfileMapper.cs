using Riok.Mapperly.Abstractions;
using StockAgent.Application.Contracts.Models;
using StockAgent.Infrastructure.Clients.Models;

namespace StockAgent.Infrastructure.Mappers
{
    [Mapper(RequiredMappingStrategy = RequiredMappingStrategy.Target)]
    public partial class FinnHubProfileMapper
    {
        [MapProperty(
            nameof(FinnHubProfileResponse.Ticker),
            nameof(StockProfile.Symbol))]
        [MapProperty(
            nameof(FinnHubProfileResponse.FinnhubIndustry),
            nameof(StockProfile.Sector))]
        [MapProperty(
            nameof(FinnHubProfileResponse.MarketCapitalization),
            nameof(StockProfile.MarketCap))]
        [MapProperty(
            nameof(FinnHubProfileResponse.ShareOutstanding),
            nameof(StockProfile.SharesOutstanding))]


        [MapperIgnoreSource(nameof(FinnHubProfileResponse.Logo))]
        [MapperIgnoreSource(nameof(FinnHubProfileResponse.Ipo))]
        [MapperIgnoreSource(nameof(FinnHubProfileResponse.FloatingShare))]
        public partial StockProfile ToStockProfile(
            FinnHubProfileResponse source);
    }
}
