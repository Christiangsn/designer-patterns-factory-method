using designer_patterns_factory_method.Src.Domain;

namespace designer_patterns_factory_method.Src.App;

public class UseCasesFactory {
    private readonly IFactoryToMethods<IDependenciesInterfaces> _dependencies;

    public UseCasesFactory(IFactoryToMethods<IDependenciesInterfaces> dependencies) {
        _dependencies = dependencies;
    }

    public void GetUseCase() {
        IHttpInterface httpRest = _dependencies.GetMethod<IHttpInterface>();
        ILogger logger = _dependencies.GetMethod<ILogger>();

        _ = httpRest.Get<string>("https://jsonplaceholder.typicode.com/todos/1");
        logger.Log("Hello");
    }
}