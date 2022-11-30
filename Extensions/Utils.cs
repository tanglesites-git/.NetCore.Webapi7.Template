using Serilog;
using ILogger = Serilog.ILogger;

namespace NetCoreWebapi7Template.Extensions;

public static class Utils
{
    public static ILogger LoggerConfiguration()
    {
        Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .Enrich.FromLogContext()
            .WriteTo.Console()
            .CreateBootstrapLogger();

        return Log.Logger;
    }
}