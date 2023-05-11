using NpgsqlTypes;
using Serilog.Events;
using Serilog.Sinks.PostgreSQL;

namespace real_estate_web.Tools.Logger
{
    public class UserIdColumnWriter : ColumnWriterBase
    {
        public UserIdColumnWriter() : base(NpgsqlDbType.Varchar)
        {
        }

        public override object GetValue(LogEvent logEvent, IFormatProvider formatProvider = null)
        {
            var (useremail, value) = logEvent.Properties.FirstOrDefault(p => p.Key == "user_id");
            return value?.ToString() ?? null;
        }
    }
}
