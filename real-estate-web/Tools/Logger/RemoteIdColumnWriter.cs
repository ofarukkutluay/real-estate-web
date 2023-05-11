using NpgsqlTypes;
using Serilog.Events;
using Serilog.Sinks.PostgreSQL;

namespace real_estate_web.Tools.Logger
{
    public class RemoteIpColumnWriter : ColumnWriterBase
    {
        public RemoteIpColumnWriter() : base(NpgsqlDbType.Varchar)
        {
        }

        public override object GetValue(LogEvent logEvent, IFormatProvider formatProvider = null)
        {
            var (remoteip, value) = logEvent.Properties.FirstOrDefault(p => p.Key == "remote_ip");
            return value?.ToString() ?? null;
        }
    }
}
