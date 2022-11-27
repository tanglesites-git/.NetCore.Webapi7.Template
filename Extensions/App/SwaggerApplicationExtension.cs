namespace api.Extensions.App;

public static class SwaggerApplicationExtension
{
    public static WebApplication UseTanglesitesSwagger(this WebApplication app)
    {
        if (!app.Environment.IsDevelopment())
            app.UseSwagger();
        return app;
    } 
}