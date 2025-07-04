using Serilog;

class Program
{
    static void Main()
    {
        Log.Logger = new LoggerConfiguration()
            .WriteTo.Console()
            .CreateLogger();

        Log.Information("Logging safely using static Log.");
        Log.CloseAndFlush(); // Proper disposal
    }
}