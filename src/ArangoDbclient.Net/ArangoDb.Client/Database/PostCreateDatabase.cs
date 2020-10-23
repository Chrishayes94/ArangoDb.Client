using System.Collections.Generic;
using ArangoDb.Client.Database.Models;
using ArangoDb.Client.Http;

namespace ArangoDb.Client.Database
{
    public class PostCreateDatabaseRequest : BaseRequest
    {
        public PostCreateDatabaseRequest() : base("/_api/database")
        {
        }

        public string Name { get; set; }

        public CreateDatabaseOptions Options { get; set; }

        public List<DatabaseUser> Users { get; set; }
    }

    public class PostCreateDatabaseResponse : BaseResponse<List<DatabaseUser>>
    {
        public string Name { get; set; }
    }
}