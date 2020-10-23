using System.Threading.Tasks;
using ArangoDb.Client.Http.Interfaces;

namespace ArangoDb.Client.Authentication
{
    public static class AuthenticationClientHandlerExtensions
    {
        public static Task<PostAuthenticationResponse> Authenticate(this IClientHandler clientHandler, string username,
            string password) => clientHandler.Authenticate(new PostAuthenticationRequest(username, password)
            {CurrentDatabase = null});
        
        public static Task<PostAuthenticationResponse> Authenticate(this IClientHandler clientHandler,
            PostAuthenticationRequest request) =>
            clientHandler.PostAsync<PostAuthenticationRequest, PostAuthenticationResponse>(request);
    }
}