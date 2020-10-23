using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ArangoDb.Client.Http
{
    public class HttpRequest<TRequest, TResponse, TError>
        where TResponse : class, IBaseResponse where TRequest : BaseRequest
    {
        private TRequest Request { get; }
        public TResponse Response { get; private set; }
        public TError ErrorResponse { get; private set; }

        private HttpRequestMessage _requestMessage;

        public HttpRequest(TRequest request)
        {
            Request = request;
        }

        public async Task SendAsync(HttpClient client)
        {
            var responseMessage = await client.SendAsync(_requestMessage);
            if (!responseMessage.IsSuccessStatusCode)
                ErrorResponse = await responseMessage.Content.ReadAsAsync<TError>();
            else Response = await responseMessage.Content.ReadAsAsync<TResponse>();
        }

        public void ConstructRequest(Func<TRequest, HttpRequestMessage> predicate) =>
            _requestMessage = predicate(Request);

        public void ConstructRequest(Func<HttpRequestMessage> predicate) => _requestMessage = predicate();
    }
}