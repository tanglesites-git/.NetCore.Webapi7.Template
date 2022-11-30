namespace NetCoreWebapi7Template.Extensions.App;

public static class SwaggerUIApplicationExtension
{
    public static WebApplication UseTanglesitesSwaggerUI(this WebApplication app)
    {
        if(!app.Environment.IsDevelopment())
            app.UseSwaggerUI();
        return app;
    }
}