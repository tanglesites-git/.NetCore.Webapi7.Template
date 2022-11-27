namespace api.Extensions.Builder;

public static class TanglesitesSwaggerGenExtension
{
    public static WebApplicationBuilder AddTanglesitesSwaggerGen(this WebApplicationBuilder builder)
    {
        builder.Services.AddSwaggerGen();
        return builder;
    }
}