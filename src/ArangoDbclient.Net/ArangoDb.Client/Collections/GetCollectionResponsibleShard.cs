using ArangoDb.Client.Http;

namespace ArangoDb.Client.Collections
{
    public class GetCollectionResponsibleShardRequest : BaseRequest
    {
        public GetCollectionResponsibleShardRequest(string collectionName) : base(
            $"/_api/collection/{collectionName}/responsibleShard")
        {
        }
    }
    
    public class GetCollectionResponsibleShardResponse : IBaseResponse
    {
        public bool Error { get; set; }
        
        public int Code { get; set; }

        public string ShardId { get; set; }
    }
}