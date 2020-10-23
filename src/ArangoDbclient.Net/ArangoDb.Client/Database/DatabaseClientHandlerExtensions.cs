using System.Threading.Tasks;
using ArangoDb.Client.Http.Interfaces;

namespace ArangoDb.Client.Database
{
    public static class DatabaseClientHandlerExtensions
    {
        public static Task<PostCreateDatabaseResponse> CreateDatabase(this IClientHandler clientHandler,
            PostCreateDatabaseRequest request) =>
            clientHandler.PostAsync<PostCreateDatabaseRequest, PostCreateDatabaseResponse>(request);

        public static Task<GetDatabasesResponse> AllDatabases(this IClientHandler clientHandler,
            GetDatabasesRequest request) => clientHandler.GetAsync<GetDatabasesRequest, GetDatabasesResponse>(request);

        public static Task<GetCurrentDatabaseResponse> CurrentDatabase(IClientHandler clientHandler,
            GetCurrentDatabaseRequest request) =>
            clientHandler.GetAsync<GetCurrentDatabaseRequest, GetCurrentDatabaseResponse>(request);

        public static Task<GetAccessibleDatabasesResponse> AccessibleDatabases(IClientHandler clientHandler,
            GetAccessibleDatabasesRequest request) =>
            clientHandler.GetAsync<GetAccessibleDatabasesRequest, GetAccessibleDatabasesResponse>(request);

        public static Task<DeleteDropDatabaseResponse> DropDatabase(IClientHandler clientHandler,
            DeleteDropDatabaseRequest request) =>
            clientHandler.DeleteAsync<DeleteDropDatabaseRequest, DeleteDropDatabaseResponse>(request);
    }
}