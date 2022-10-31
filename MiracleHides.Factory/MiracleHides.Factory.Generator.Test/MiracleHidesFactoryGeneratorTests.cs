namespace MiracleHides.Factory.Generator.Test
{
    using Xunit;
    using MiracleHides.Factory.Generator;
    using MiracleHides.Factory.Generator.Contracts;

    /// <summary>
    ///     Tests for <see cref="MiracleHidesFactoryGenerator"/>.
    /// </summary>
    public class MiracleHidesFactoryGeneratorTests
    {
        private readonly IMiracleHidesFactoryGenerator generator;

        public MiracleHidesFactoryGeneratorTests(IMiracleHidesFactoryGenerator generator)
        {
            this.generator = generator;
        }

        [Theory]
        [InlineData("examples/crud/csharp.json")]
        [InlineData("examples/crud/nestjs.json")]
        [InlineData("examples/crud/nodejs.json")]
        [InlineData("examples/crud/python.json")]
        public void GenerateSourceCode(string jsonFileName)
        {
            var archive = this.generator.Generate(jsonFileName);
            Assert.NotNull(archive);
        }
    }
}
