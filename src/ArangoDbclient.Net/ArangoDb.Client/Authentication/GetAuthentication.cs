using ArangoDb.Client.Http;

namespace ArangoDb.Client.Authentication
{
    public class PostAuthenticationRequest : BaseRequest
    {
        public PostAuthenticationRequest(string username, string password) : base("/_open/auth")
        {
            Username = username;
            Password = password;
        }

        public string Username { get; set; }

        public string Password { get; set; }
    }
    
    public class PostAuthenticationResponse : IBaseResponse
    {
        public bool Error { get; set; }
        
        public int Code { get; set; }

        public string Jwt { get; set; }
    }
}