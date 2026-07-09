using System.Net;

namespace StockAgent.Infrastructure.Common
{
    public sealed class ExternalApiException : Exception
    {
        public string Provider { get; }

        public string? RequestUri { get; }

        public HttpStatusCode StatusCode { get; }

        public ExternalApiException(
            string provider,
            string? requestUri,
            HttpStatusCode statusCode,
            string message,
            Exception? innerException = null)
            : base(message, innerException)
        {
            Provider = provider;
            RequestUri = requestUri;
            StatusCode = statusCode;
        }
    }
}
