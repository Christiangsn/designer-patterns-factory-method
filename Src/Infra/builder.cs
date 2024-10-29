using designer_patterns_factory_method.Src.App;
using designer_patterns_factory_method.Src.Domain;
using designer_patterns_factory_method.Src.infra;

namespace designer_patterns_factory_method.Src.Infra;

public static class Builder 
{
    public static void Go()
    {
        IFactoryToMethods<IDependenciesInterfaces> infra = BuilderInfra();
        var Cases = new UseCasesFactory(infra);
        Cases.GetUseCase();
    }

    private static IFactoryToMethods<IDependenciesInterfaces> BuilderInfra () {
        return new Factory();
    }
}