namespace real_estate_web.Tools.Results
{
    public class DataResult<T> : Result
    {
        private T Data { get; set; }
        public DataResult(string message, bool status) : base(message, status)
        {
        }

        public DataResult(T data, string message, bool status) : base(message, status)
        {
            Data = data;
        }
    }
}
