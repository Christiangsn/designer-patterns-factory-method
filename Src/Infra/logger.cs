using designer_patterns_factory_method.Src.Domain;

namespace designer_patterns_factory_method.Src.Infra;

public class Logger: ILogger
{
    public void Log(string message)
    {
        Console.WriteLine("Logger: " + message);
    }
}