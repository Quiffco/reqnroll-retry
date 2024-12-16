using Reqnroll.Generator.Plugins;
using Reqnroll.Generator.UnitTestConverter;
using Reqnroll.Infrastructure;
using Reqnroll.RetryCore;
using Reqnroll.UnitTestProvider;

[assembly: GeneratorPlugin(typeof(GeneratorPlugin))]
namespace Reqnroll.RetryCore
{
    public class GeneratorPlugin : IGeneratorPlugin
    {
        public void Initialize(GeneratorPluginEvents generatorPluginEvents, GeneratorPluginParameters generatorPluginParameters,
            UnitTestProviderConfiguration unitTestProviderConfiguration)
        {
            generatorPluginEvents.RegisterDependencies += (sender, args) =>
                {
                    args.ObjectContainer.RegisterTypeAs<RetryUnitTestFeatureGenerator, IFeatureGenerator>();
                    args.ObjectContainer.RegisterTypeAs<RetryUnitTestFeatureGeneratorProvider, IFeatureGeneratorProvider>("retry");
                    args.ObjectContainer.RegisterTypeAs<RemoveRetryTagFromCategoriesDecorator, ITestClassTagDecorator>("retry");
                    args.ObjectContainer.RegisterTypeAs<RemoveRetryTagFromCategoriesDecorator, ITestMethodTagDecorator>("retry");
                };
        }
    }
}

