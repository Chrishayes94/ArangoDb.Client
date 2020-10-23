using ArangoDb.Client.Http;

namespace ArangoDb.Client.Collections
{
    public class BaseCollectionResponse : IBaseResponse
    {
        public bool Error { get; set; }
        
        public int Code { get; set; }
        
        public int WriteConcern { get; set; }

        public bool WaitForSync { get; set; }

        public int Type { get; set; }

        public string TempObjectId { get; set; }

        public string Id { get; set; }

        public bool CacheEnabled { get; set; }

        public bool IsSmartChild { get; set; }

        public string ObjectId { get; set; }

        public string GloballyUniqueId { get; set; }

        public string Schema { get; set; }

        public object KeyOptions { get; set; } // TODO

        public bool IsSystem { get; set; }

        public bool IsDisjoint { get; set; }

        public string Name { get; set; }

        public string StatusString { get; set; }

        public int Status { get; set; }
    }
}