namespace ArangoDb.Client.Collections.Models
{
    public class CollectionData
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public int Status { get; set; }

        public int Type { get; set; }

        public bool IsSystem { get; set; }

        public string GloballyUniqueId { get; set; }
    }
}