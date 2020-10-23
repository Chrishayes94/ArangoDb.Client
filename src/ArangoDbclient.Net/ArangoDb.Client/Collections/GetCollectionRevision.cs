using ArangoDb.Client.Http;

namespace ArangoDb.Client.Collections
{
    public class GetCollectionRevisionRequest: BaseRequest
    {
        public GetCollectionRevisionRequest(string collectionName) : base($"/_api/collection/{collectionName}/revision")
        {
        }
    }

    public class GetCollectionRevisionResponse : BaseCollectionResponse
    {
        public string Revision { get; set; }
    }
}