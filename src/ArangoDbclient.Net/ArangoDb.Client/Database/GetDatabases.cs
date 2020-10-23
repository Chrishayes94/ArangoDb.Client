using System.Collections.Generic;
using ArangoDb.Client.Http;

namespace ArangoDb.Client.Database
{
    public class GetDatabasesRequest : BaseRequest
    {
        public GetDatabasesRequest() : base("/_api/database")
        {
        }
    }

    public class GetDatabasesResponse : BaseResponse<List<string>>
    {
    }
}