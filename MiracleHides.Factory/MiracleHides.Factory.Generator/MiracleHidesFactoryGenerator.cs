namespace MiracleHides.Factory.Generator
{
    using System.IO.Compression;
    using MiracleHides.Factory.Generator.Contracts;

    /// <summary>
    ///     Describes the operations of a software generator.
    /// </summary>
    public class MiracleHidesFactoryGenerator : IMiracleHidesFactoryGenerator
    {
        /// <summary>
        ///     Generate source code for the given <paramref name="jsonFileName"/> specification.
        /// </summary>
        /// <param name="jsonFileName">The path of the json file.</param>
        /// <returns>The source code as <see cref="byte[]"/> in zip format.</returns>
        public byte[] Generate(string jsonFileName)
        {
            return new byte[0];
        }
    }
}
