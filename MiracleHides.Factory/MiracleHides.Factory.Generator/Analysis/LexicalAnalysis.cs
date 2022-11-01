namespace MiracleHides.Factory.Generator.Analysis
{
    using System.Threading.Tasks;
    using MiracleHides.Factory.Generator.Contracts.Analysis;
    using MiracleHides.Factory.Generator.Contracts.Models.JsonSpecification;
    using MiracleHides.Factory.Generator.Converter;

    /// <summary>
    ///     Describes the operations of the lexical analysis.
    /// </summary>
    internal class LexicalAnalysis : ILexicalAnalysis
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
