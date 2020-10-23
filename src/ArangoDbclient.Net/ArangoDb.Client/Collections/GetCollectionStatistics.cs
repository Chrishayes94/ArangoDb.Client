using ArangoDb.Client.Collections.Models;
using ArangoDb.Client.Http;

namespace ArangoDb.Client.Collections
{
    public class GetCollectionStatisticsRequest : BaseRequest
    {
        public GetCollectionStatisticsRequest(string collectionName) : base(
            $"/_api/collection/{collectionName}/figures")
        {
            
        }
    }

    public class GetCollectionStatisticsResponse : BaseCollectionResponse
    {
        public int Count { get; set; }

        public CollectionFigures Figures { get; set; }
    }
}