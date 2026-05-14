using Portal.Common.Logging;

namespace Portal.Infrastructure.Logging;

public class FileLogger : ILogger
{
    private const string Path = "logs/app.log";

    public void Log(string message)
    {
        Directory.CreateDirectory("logs");
        File.AppendAllText(
            Path,
            $"{DateTime.UtcNow:o} | {message}\n");
    }
}