using Serilog;
using ILogger = Serilog.ILogger;

namespace api.Extensions;

public static class Utils
{
    public static ILogger LoggerConfiguration()
    {
        return new LoggerConfiguration()
            .MinimumLevel.Information()
            .Enrich.FromLogContext()
            .WriteTo.Console()
            .CreateLogger();
    } 
}