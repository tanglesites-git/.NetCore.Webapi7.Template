using Serilog;

namespace NetCoreWebapi7Template.Extensions.App;

public static class HttpsRedirectionApplicationExtension
{
    public static WebApplication UseTanglesitesHttpsRedirection(this WebApplication app)
    {
        //app.UseSerilogRequestLogging();
        app.UseHttpsRedirection();
        return app;
    }
}