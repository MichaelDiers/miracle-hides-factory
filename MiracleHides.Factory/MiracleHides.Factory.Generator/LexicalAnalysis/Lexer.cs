namespace MiracleHides.Factory.Generator.LexicalAnalysis
{
    using System.Threading.Tasks;
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
        /// <returns>A <see cref="Task{T}"/> whose result is a parsed <see cref="ISpecification"/>.</returns>
        public Task<ISpecification> Execute(string content)
        {
            var specification = SpecificationJsonConverter.Deserialize(content);
            return Task.FromResult<ISpecification>(specification);
        }
    }
}
