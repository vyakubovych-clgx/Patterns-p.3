using Task4.Interfaces;

namespace Task4.Implementations;

public class Logger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"Log: {message}");
    }
}