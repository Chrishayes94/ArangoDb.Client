namespace ArangoDb.Client.Database.Models
{
    public class CreateDatabaseOptions
    {
        public Sharding Sharding { get; set; }

        public string ReplicationFactor { get; set; }

        public string WriteConcern { get; set; }
    }
}