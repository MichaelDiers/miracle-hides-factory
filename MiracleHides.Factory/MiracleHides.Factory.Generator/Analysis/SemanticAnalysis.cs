namespace MiracleHides.Factory.Generator.Analysis
{
    using System.Threading.Tasks;
    using MiracleHides.Factory.Generator.Contracts.Analysis;
    using MiracleHides.Factory.Generator.Contracts.Models.JsonSpecification;

    /// <summary>
    ///     The semantic analysis of the code generator.
    /// </summary>
    internal abstract class SemanticAnalysis : ISemanticAnalysis
    {
        /// <summary>
        /// Create a new instance of the <see cref="SemanticAnalysis"/> class.
        /// </summary>
        /// <param name="language">The language for that the analysis is executed.</param>
        /// <param name="specificationType">The specification type for that the analysis is executed.</param>
        protected SemanticAnalysis(Language language, SpecificationType specificationType)
        {
            Language = language;
            SpecificationType = specificationType;
        }

        /// <summary>
        ///     Gets the supported <see cref="Language"/> for this analyzer.
        /// </summary>
        public Language Language { get; }

        /// <summary>
        ///     Gets the supported <see cref="SpecificationType"/> for this analyzer.
        /// </summary>
        public SpecificationType SpecificationType { get; }

        /// <summary>
        ///     Execute the semantic analysis.
        /// </summary>
        /// <param name="specification">The specification that is used for generating code.</param>
        /// <returns>A <see cref="Task{T}"/> whose result is the given <paramref name="specification"/>.</returns>
        public virtual Task<ISpecification> Execute(ISpecification specification)
        {
            return Task.FromResult(specification);
        }
    }
}
