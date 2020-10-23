namespace ArangoDb.Client.Database.Models
{
    public class DatabaseUser
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public bool Active { get; set; }

        public object Extra { get; set; }
    }
}