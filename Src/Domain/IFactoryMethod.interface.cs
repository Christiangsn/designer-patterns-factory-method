namespace designer_patterns_factory_method.Src.Domain;

public interface IDependenciesInterfaces
{
    IHttpInterface Http { get; }
    ILogger Logger { get; }
}

 public interface IFactoryToMethods<TCluster>
{
    TDependency GetMethod<TDependency>() where TDependency : class;
}
