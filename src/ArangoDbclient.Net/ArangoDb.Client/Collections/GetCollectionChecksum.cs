using ArangoDb.Client.Http;

namespace ArangoDb.Client.Collections
{
    public class GetCollectionChecksumRequest : BaseRequest
    {
        public GetCollectionChecksumRequest(string collectionName) : base($"/_api/collection/{collectionName}/checksum")
        {
        }

        public bool WithRevisions { get; set; }

        public bool WithData { get; set; }
    }

    public class GetCollectionChecksumResponse : BaseCollectionResponse
    {
        public string Revision { get; set; }

        public string Checksum { get; set; }
    }
}