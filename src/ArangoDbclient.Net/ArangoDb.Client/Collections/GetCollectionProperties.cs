using ArangoDb.Client.Http;

namespace ArangoDb.Client.Collections
{
    public class GetCollectionPropertiesRequest : BaseRequest
    {
        public GetCollectionPropertiesRequest(string collectionName) : base(
            $"/_api/collection/{collectionName}/properties")
        {
        }
    }

    public class GetCollectionPropertiesResponse : BaseCollectionResponse
    {
    }
    
}