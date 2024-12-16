namespace Reqnroll.RetryCore
{
    using Reqnroll.Generator.UnitTestConverter;
    using Reqnroll.Parser;

    public class RetryUnitTestFeatureGeneratorProvider : IFeatureGeneratorProvider
    {
        private readonly RetryUnitTestFeatureGenerator _unitTestFeatureGenerator;

        public RetryUnitTestFeatureGeneratorProvider(RetryUnitTestFeatureGenerator unitTestFeatureGenerator)
        {
            this._unitTestFeatureGenerator = unitTestFeatureGenerator;
        }

        public bool CanGenerate(ReqnrollDocument document)
        {
            return true;
        }

        public IFeatureGenerator CreateGenerator(ReqnrollDocument document)
        {
            return this._unitTestFeatureGenerator;
        }

        public int Priority => PriorityValues.Normal;
    }
}