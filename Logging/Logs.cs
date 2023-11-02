namespace SerilogWeb.v4.Logging
{
    using Serilog;
    using Serilog.Sinks.Graylog;

    public class Logs
    {
        public static void StartLogging()
        {
            var log = new LoggerConfiguration()
                .WriteTo.Graylog(new GraylogSinkOptions
                {
                    HostnameOrAddress = "localhost",
                    TransportType = Serilog.Sinks.Graylog.Core.Transport.TransportType.Tcp,
                    Port = 12201
                })
                .WriteTo.Debug();
            Log.Logger = log.CreateLogger();
            Log.Logger.Information("Logger created");
        }
    }
}