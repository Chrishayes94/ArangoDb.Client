using ArangoDb.Client.Http;

namespace ArangoDb.Client.Collections
{
    public class GetCollectionRequest : BaseRequest
    {
        public GetCollectionRequest(string collectionName) : base($"/_api/collection/{collectionName}")
        {
        }
    }

    public class GetCollectionResponse : BaseResponse<int>
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public int Status { get; set; }

        public int Type { get; set; }

        public bool IsSystem { get; set; }
    }
}