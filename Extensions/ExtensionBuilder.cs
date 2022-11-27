using api.Extensions.Builder;
using ILogger = Serilog.ILogger;

namespace api.Extensions;

public static class ExtensionBuilder
{
    public static WebApplicationBuilder AddTanglesitesTemplate(this WebApplicationBuilder builder, ILogger logger)
    {
        builder
            .AddLogging(logger)
            .AddEndpointsApiExplorer()
            .AddSwaggerGen();
        return builder;
    }
}