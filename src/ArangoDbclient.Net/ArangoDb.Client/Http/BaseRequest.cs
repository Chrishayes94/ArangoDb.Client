using System.Text.Json.Serialization;
using ArangoDb.Client.Attributes;

namespace ArangoDb.Client.Http
{
    public abstract class BaseRequest
    {
        protected BaseRequest(string endpoint)
        {
            Endpoint = endpoint;
        }
        
        [JsonIgnore, QueryIgnore]
        public string Endpoint { get; set; }

        [JsonIgnore, QueryIgnore] 
        public string AuthenticationToken { get; set; }

        [JsonIgnore, QueryIgnore] public string CurrentDatabase { get; set; } = "_system";
    }
}