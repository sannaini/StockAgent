using System.Net.Http.Json;
using System.Text.Json;

namespace StockAgent.Infrastructure.Common
{
    public static class HttpResponseExtensions
    {
        public static async Task<T?> ReadContentAsAsync<T>(
            this HttpResponseMessage response,
            string provider,
            CancellationToken cancellationToken)
        {
            if (!response.IsSuccessStatusCode)
            {
                var errorBody = await response.Content.ReadAsStringAsync(
                    cancellationToken);

                throw new ExternalApiException(
                    provider,
                    response.RequestMessage?.RequestUri?.ToString(),
                    response.StatusCode,
                    $"External API call failed. Provider: {provider}. " +
                    $"StatusCode: {response.StatusCode}. " +
                    $"Response: {errorBody}");
            }

            try
            {
                return await response.Content
                    .ReadFromJsonAsync<T>(
                        cancellationToken: cancellationToken);
            }
            catch (JsonException ex)
            {
                throw new ExternalApiException(
                    provider,
                    response.RequestMessage?.RequestUri?.ToString(),
                    response.StatusCode,
                    "Failed to deserialize external API response.",
                    ex);
            }
        }
    }
}
