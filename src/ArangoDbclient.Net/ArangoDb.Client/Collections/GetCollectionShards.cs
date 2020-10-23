using System.Collections.Generic;
using ArangoDb.Client.Http;

namespace ArangoDb.Client.Collections
{
    public class GetCollectionShardsRequest : BaseRequest
    {
        public GetCollectionShardsRequest(string collectionName) : base($"/_api/collection/{collectionName}/shards")
        {
        }
    }

    public class GetCollectionShardsResponse : BaseCollectionResponse
    {
        public List<object> Shards { get; set; }

        public string ShardingStrategy { get; set; }

        public List<string> ShardKeys { get; set; }

        public int NumberOfShards { get; set; }

        public int MinReplicationFactor { get; set; }
    }
}