using System.Net.Http;

namespace ArangoDb.Client.Http.Interfaces
{
    public interface IHttpClientFactory
    {
        HttpClient Create(string baseUrl);
    }
}