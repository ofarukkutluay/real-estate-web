namespace real_estate_web.Tools.Results
{
    public class Result
    {
        private string Message { get; set; }
        private bool Status { get; set; }

        public Result(string message, bool status)
        {
            Message = message;
            Status = status;
        }
    }
}
