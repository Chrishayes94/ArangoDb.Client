using ArangoDb.Client.Database.Models;
using ArangoDb.Client.Http;

namespace ArangoDb.Client.Database
{
    public class GetCurrentDatabaseRequest : BaseRequest
    {
        public GetCurrentDatabaseRequest() : base("/_api/database/current")
        {
        }
    }

    public class GetCurrentDatabaseResponse : BaseResponse<CurrentDatabase>
    {
    }
}