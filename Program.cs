using api.Extensions;
using Serilog;

var config = Utils.LoggerConfiguration();

var builder = WebApplication.CreateBuilder(args)
    .AddTanglesitesTemplate(config);

var app = builder.Build()
    .UseTanglesites();
try
{
    Log.Information("Running Application...");
    app.Run();
}
catch (Exception ex)
{
    Log.Fatal("Error");
    Console.WriteLine(ex.Message);
}
finally
{
    Log.CloseAndFlush();
}

