using System.Text.Json.Serialization;

namespace ArangoDb.Client.Http
{
    public abstract class BaseRequest
    {
        public BaseRequest(string endpoint)
        {
            Endpoint = endpoint;
        }
        
        [JsonIgnore]
        public string Endpoint { get; set; }
    }
}