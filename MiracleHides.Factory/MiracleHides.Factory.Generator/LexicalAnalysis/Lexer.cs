namespace MiracleHides.Factory.Generator.LexicalAnalysis
{
    using MiracleHides.Factory.Generator.Contracts.LexicalAnalysis;
    using MiracleHides.Factory.Generator.Contracts.Models.JsonSpecification;
    using MiracleHides.Factory.Generator.Converter;

    /// <summary>
    ///     Describes the operations of the lixical analysis.
    /// </summary>
    internal class Lexer : ILexer
    {
        /// <summary>
        ///     Execute the lexical analysis.
        /// </summary>
        /// <param name="content">The specification in json file format.</param>
        /// <returns>A parsed <see cref="ISpecification"/>.</returns>
        public ISpecification Execute(string content)
        {
            return SpecificationJsonConverter.Deserialize(content);
        }
    }
}
