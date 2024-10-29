using designer_patterns_factory_method.Src.Domain;

namespace designer_patterns_factory_method.Src.Infra;

public class Http: IHttpInterface
{
    public T Get<T>(string url)
    {
        Console.WriteLine("Http Request!!!");
        return (T)(object)"released";
    }
}
