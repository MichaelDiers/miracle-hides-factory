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
        [Fact]
        public void MiracleHidesFactoryGenerator_implements_IMiracleHidesFactoryGenerator()
        {
            var generator = new MiracleHidesFactoryGenerator();
            Assert.IsAssignableFrom<IMiracleHidesFactoryGenerator>(generator);
        }

        [Theory]
        [InlineData("examples/crud/csharp.json")]
        public void GenerateSourceCode(string jsonFileName)
        {
            var generator = new MiracleHidesFactoryGenerator() as IMiracleHidesFactoryGenerator;
            var archive = generator.Generate(jsonFileName);
            Assert.NotNull(archive);
        }
    }
}
