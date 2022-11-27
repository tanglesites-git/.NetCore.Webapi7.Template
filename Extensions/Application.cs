using api.Extensions.App;

namespace api.Extensions;

public static class TanglesitesApplication
{
    public static WebApplication UseTanglesites(this WebApplication app)
    {
        app
            .UseTanglesitesSwagger()
            .UseTanglesitesSwaggerUI()
            .UseTanglesitesHttpsRedirection();
        return app;
    }
}