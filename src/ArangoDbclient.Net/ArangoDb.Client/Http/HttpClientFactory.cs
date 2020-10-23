using System;
using System.Net.Http;
using ArangoDb.Client.Http.Interfaces;

namespace ArangoDb.Client.Http
{
    public class HttpClientFactory : IHttpClientFactory
    {
        private static volatile HttpClient _httpClient;
        private static volatile object _lock = new object();
        
        public HttpClient Create(string baseUrl)
        {
            HttpClient client;
            lock (_lock)
            {
                if (_httpClient == null) _httpClient = new HttpClient { BaseAddress = new Uri(baseUrl)};
                client = _httpClient;
            }

            return client;
        }
    }
}