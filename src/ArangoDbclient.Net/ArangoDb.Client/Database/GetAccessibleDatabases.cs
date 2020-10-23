using System.Collections.Generic;
using ArangoDb.Client.Http;

namespace ArangoDb.Client.Database
{
    public class GetAccessibleDatabasesRequest : BaseRequest
    {
        public GetAccessibleDatabasesRequest() : base("/_api/database/user")
        {
        }
    }

    public class GetAccessibleDatabasesResponse : BaseResponse<List<string>>
    {
    }
}