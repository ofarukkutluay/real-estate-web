namespace real_estate_web.Models.Database
{
    public class Log : BaseEntity
    {
        public string LogType { get; set; }
        public string Message { get; set; }

    }
}
