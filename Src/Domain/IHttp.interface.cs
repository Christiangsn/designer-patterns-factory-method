namespace designer_patterns_factory_method.Src.Domain;

public interface IHttpInterface
{
    T Get<T>(string url);
}