using NetCoreWebapi7Template.Extensions.Builder;
using ILogger = Serilog.ILogger;

namespace NetCoreWebapi7Template.Extensions;

public static class ExtensionBuilder
{
    public static WebApplicationBuilder AddTanglesites(this WebApplicationBuilder builder, ILogger logger)
    {
        builder
            .AddTanglesitesLogging(logger)
            .AddTanglesitesEndpointsApiExplorer()
            .AddTanglesitesSwaggerGen();
        return builder;
    }
}