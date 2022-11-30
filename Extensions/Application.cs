using NetCoreWebapi7Template.Extensions.App;

namespace NetCoreWebapi7Template.Extensions;

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