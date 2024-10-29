using designer_patterns_factory_method.Src.Domain;
using designer_patterns_factory_method.Src.Infra;

namespace designer_patterns_factory_method.Src.infra;

public class Factory: IFactoryToMethods<IDependenciesInterfaces>
{
    public TDependency GetMethod<TDependency>() where TDependency : class
    {

        if (typeof(TDependency) == typeof(IHttpInterface)) return (new Http() as TDependency)!;
        if (typeof(TDependency) == typeof(ILogger)) return (new Logger() as TDependency)!;

        throw new Exception("Invalid type");
    }
}