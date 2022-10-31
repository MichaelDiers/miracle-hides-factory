namespace MiracleHides.Factory.Generator.Contracts
{
    /// <summary>
    ///     Describes the operations of a software generator.
    /// </summary>
    public interface IMiracleHidesFactoryGenerator
    {
        /// <summary>
        ///     Generate source code for the given <paramref name="jsonFileName"/> specification.
        /// </summary>
        /// <param name="jsonFileName">The path of the json file.</param>
        /// <returns>The source code as <see cref="byte[]"/> in zip format.</returns>
        byte[] Generate(string jsonFileName);
    }
}
