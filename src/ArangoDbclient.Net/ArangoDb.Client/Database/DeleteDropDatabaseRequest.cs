using ArangoDb.Client.Http;

namespace ArangoDb.Client.Database
{
    public class DeleteDropDatabaseRequest : BaseRequest
    {
        public DeleteDropDatabaseRequest(string databaseName) : base($"/_api/database/{databaseName}")
        {}
    }
    
    public class DeleteDropDatabaseResponse : BaseResponse<bool>
    {}
}