namespace MiracleHides.Factory.Generator.Contracts
{
    using System.Threading.Tasks;

    /// <summary>
    ///     Describes the operations of a software generator.
    /// </summary>
    public interface IMiracleHidesFactoryGenerator
    {
        /// <summary>
        ///     Generate source code for the given <paramref name="jsonFileName"/> specification.
        /// </summary>
        /// <param name="jsonFileName">The path of the json file.</param>
        /// <returns>A <see cref="Task{T}"/> whose result is the source code as <see cref="byte[]"/> in zip format.</returns>
        Task<byte[]> Generate(string jsonFileName);
    }
}
