using Serilog;

namespace api.Extensions.App;

public static class HttpsRedirectionApplicationExtension
{
    public static WebApplication UseTanglesitesHttpsRedirection(this WebApplication app)
    {
        //app.UseSerilogRequestLogging();
        app.UseHttpsRedirection();
        return app;
    }
}