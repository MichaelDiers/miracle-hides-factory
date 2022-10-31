namespace MiracleHides.Factory.Generator.Contracts.LexicalAnalysis
{
    using MiracleHides.Factory.Generator.Contracts.Models.JsonSpecification;

    /// <summary>
    ///     Describes the operations of the lixical analysis.
    /// </summary>
    public interface ILexer
    {
        /// <summary>
        ///     Execute the lexical analysis.
        /// </summary>
        /// <param name="content">The specification in json file format.</param>
        /// <returns>A parsed <see cref="ISpecification"/>.</returns>
        ISpecification Execute(string content);
    }
}
