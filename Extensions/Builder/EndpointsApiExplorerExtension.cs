namespace api.Extensions.Builder;

public static class EndpointsApiExplorerExtension
{
    public static WebApplicationBuilder AddTanglesitesEndpointsApiExplorer(this WebApplicationBuilder builder)
    {
        builder.Services.AddEndpointsApiExplorer();
        return builder;
    }
}