using StockAgent.Application.Contracts.Interfaces.Clients;
using StockAgent.Application.Contracts.Models;
using StockAgent.Domain.ValueObjects;
using StockAgent.Infrastructure.Clients.Models;
using StockAgent.Infrastructure.Common;
using StockAgent.Infrastructure.Mappers;

namespace StockAgent.Infrastructure.Clients
{
    public class FinnHubClient(HttpClient httpClient, FinnHubProfileMapper mapper) : IStockApiClient
    {
        public async Task<StockProfile?> GetStockDetailsAsync(Isin isin, CancellationToken cancellationToken = default)
        {
            var result = await httpClient.GetAsync("stock/profile2?isin=" + isin.Value, cancellationToken);

            var response = await result.ReadContentAsAsync
                <FinnHubProfileResponse>("FinnHub", cancellationToken);

            if (response is null)
                return null;

            var stockProfile = mapper.ToStockProfile(response);
            stockProfile.SetIsin(isin.Value);

            return stockProfile;

        }
        
    }
}
