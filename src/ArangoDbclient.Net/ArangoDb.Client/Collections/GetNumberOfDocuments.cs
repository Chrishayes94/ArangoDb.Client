using ArangoDb.Client.Http;

namespace ArangoDb.Client.Collections
{
    public class GetNumberOfDocumentsRequest : BaseRequest
    {
        public GetNumberOfDocumentsRequest(string collectionName) : base($"/_api/collection/{collectionName}/count")
        {
        }
    }

    public class GetNumberOfDocumentsResponse : BaseCollectionResponse
    {
        public int Count { get; set; }
    } 
}