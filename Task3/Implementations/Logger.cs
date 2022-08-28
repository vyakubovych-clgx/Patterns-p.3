using Task3.Interfaces;

namespace Task3.Implementations;

public class Logger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"Log: {message}");
    }
}