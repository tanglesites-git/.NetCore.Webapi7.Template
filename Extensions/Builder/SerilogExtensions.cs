using Microsoft.Extensions.Logging.Configuration;

using Serilog;
using ILogger = Serilog.ILogger;

namespace api.Extensions.Builder;

public static class SerilogExtensions
{
    public static WebApplicationBuilder AddTanglesitesLogging(this WebApplicationBuilder builder, ILogger logger)
    {

        builder.Logging.ClearProviders();
        builder.Logging.AddSerilog(logger);
        return builder;        
    }
}