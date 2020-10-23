namespace ArangoDb.Client.Database.Models
{
    public class CurrentDatabase
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public bool IsSystem { get; set; }

        public string Path { get; set; }
    }
}