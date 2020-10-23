namespace ArangoDb.Client.Http
{
    public interface IBaseResponse
    {
        bool Error { get; set; }

        int Code { get; set; }
    }
    
    public abstract class BaseResponse<T> : IBaseResponse
    {
        public bool Error { get; set; }

        public int Code { get; set; }

        public T Result { get; set; }
    }
}