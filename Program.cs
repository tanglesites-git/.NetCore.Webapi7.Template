using NetCoreWebapi7Template.Extensions;
using Serilog;



var builder = WebApplication.CreateBuilder(args).
    AddTanglesites(Utils.LoggerConfiguration());

var app = builder.Build()
    .UseTanglesites();

try
{

    app.MapGet("hello", () => "HELLO WORLD!");

    Log.Information("Running Application...");
    app.Run();
}
catch (Exception ex)
{
    Log.Fatal("Fatal Error Has Occured");
    Console.WriteLine(ex.Message);
}
finally
{
    Log.Information("Flushing Stream and Disposing");
    Log.CloseAndFlush();
}

