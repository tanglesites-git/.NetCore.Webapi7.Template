using api.Extensions.Builder;
using ILogger = Serilog.ILogger;

namespace api.Extensions;

public static class ExtensionBuilder
{
    public static WebApplicationBuilder AddTanglesitesTemplate(this WebApplicationBuilder builder, ILogger logger)
    {
        builder
            .AddTanglesitesLogging(logger)
            .AddTanglesitesEndpointsApiExplorer()
            .AddTanglesitesSwaggerGen();
        return builder;
    }
}