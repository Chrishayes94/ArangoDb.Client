namespace ArangoDb.Client.Http
{
    public class BaseError
    {
        public bool Error { get; set; }

        public string ErrorMessage { get; set; }

        public int Code { get; set; }

        public int ErrorNum { get; set; }

        public override string ToString() => $"[{Code}] {ErrorNum} - {ErrorMessage}";
    }
}