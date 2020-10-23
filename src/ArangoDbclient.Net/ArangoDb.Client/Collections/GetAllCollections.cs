using System.Collections.Generic;
using ArangoDb.Client.Collections.Models;
using ArangoDb.Client.Http;

namespace ArangoDb.Client.Collections
{
    public class GetAllCollectionsRequest : BaseRequest
    {
        public GetAllCollectionsRequest() : base("/_api/collection")
        {
        }
    }

    public class GetAllCollectionsResponse : BaseResponse<List<CollectionData>>
    {
    }
}