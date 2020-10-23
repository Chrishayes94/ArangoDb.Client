using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using ArangoDb.Client.Http.Interfaces;

namespace ArangoDb.Client.Http
{
    public class  ClientHandler : IClientHandler
    {
        private readonly IHttpClientFactory _httpClientFactory;

        private static JsonSerializerOptions _jsonSerializerOptions = new JsonSerializerOptions
            {PropertyNamingPolicy = JsonNamingPolicy.CamelCase};
        
        public ClientHandler(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<TResponse> PostAsync<TRequest, TResponse>(TRequest request,
            CancellationToken cancellationToken = default) where TRequest : BaseRequest
            where TResponse : class, IBaseResponse
        {
            var client = _httpClientFactory.Create("http://127.0.0.1:8529");
            var httpRequest = new HttpRequest<TRequest, TResponse>(request);
            
            httpRequest.ConstructRequest(() =>
            {
                var endpoint = string.IsNullOrEmpty(request.CurrentDatabase)
                    ? request.Endpoint
                    : $"_db/{request.CurrentDatabase}{request.Endpoint}";

                var message = new HttpRequestMessage(HttpMethod.Post, endpoint)
                {
                    Content = new StringContent(JsonSerializer.Serialize(request, _jsonSerializerOptions), Encoding.Default, "application/json")
                };
                if (!string.IsNullOrEmpty(request.AuthenticationToken))
                    message.Headers.Authorization = new AuthenticationHeaderValue("bearer", request.AuthenticationToken);
                return message;
            });

            await httpRequest.SendAsync(client, _jsonSerializerOptions).ConfigureAwait(false);
            
            return httpRequest.Response;
        }

        public async Task<TResponse> GetAsync<TRequest, TResponse>(TRequest request,
            CancellationToken cancellationToken = default) where TRequest : BaseRequest
            where TResponse : class, IBaseResponse
        {
            var client = _httpClientFactory.Create("http://127.0.0.1:8529");
            var httpRequest = new HttpRequest<TRequest, TResponse>(request);
            
            httpRequest.ConstructRequest(() =>
            {
                var endpoint = string.IsNullOrEmpty(request.CurrentDatabase)
                    ? request.Endpoint
                    : $"_db/{request.CurrentDatabase}{request.Endpoint}";

                // TODO Add Query
                
                var message = new HttpRequestMessage(HttpMethod.Get, endpoint);
                if (!string.IsNullOrEmpty(request.AuthenticationToken))
                    message.Headers.Authorization = new AuthenticationHeaderValue("bearer", request.AuthenticationToken);
                
                return message;
            });

            await httpRequest.SendAsync(client, _jsonSerializerOptions).ConfigureAwait(false);
            
            return httpRequest.Response;
        }

        public Task<TResponse> DeleteAsync<TRequest, TResponse>(TRequest request,
            CancellationToken cancellationToken = default) where TRequest : BaseRequest
            where TResponse : class, IBaseResponse
        {
            throw new System.NotImplementedException();
        }
    }
}