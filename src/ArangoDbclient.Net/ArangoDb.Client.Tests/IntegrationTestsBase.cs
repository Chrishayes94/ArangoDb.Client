using ArangoDb.Client.Http;
using ArangoDb.Client.Http.Interfaces;

namespace ArangoDb.Client.Tests
{
    public class IntegrationTestsBase
    {
        protected IHttpClientFactory ClientFactory;
        protected IClientHandler ClientHandler;

        public IntegrationTestsBase()
        {
            ClientFactory = new HttpClientFactory();
            ClientHandler = new ClientHandler(ClientFactory);
        }
    }
}