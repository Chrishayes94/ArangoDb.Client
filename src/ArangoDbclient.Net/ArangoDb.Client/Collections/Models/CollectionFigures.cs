namespace ArangoDb.Client.Collections.Models
{
    public class CollectionFigures
    {
        public CollectionFigureIndex Indexes { get; set; }
    }

    public class CollectionFigureIndex
    {
        public int Count { get; set; }

        public int Size { get; set; }
    }
}