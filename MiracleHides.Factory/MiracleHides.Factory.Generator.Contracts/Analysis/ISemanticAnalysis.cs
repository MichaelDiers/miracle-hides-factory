namespace MiracleHides.Factory.Generator.Contracts.Analysis
{
    using System.Threading.Tasks;
    using MiracleHides.Factory.Generator.Contracts.Models.JsonSpecification;

    /// <summary>
    ///     The semantic analysis of the code generator.
    /// </summary>
    public interface ISemanticAnalysis
    {
        /// <summary>
        ///     Gets the supported <see cref="Language"/> for this analyzer.
        /// </summary>
        Language Language { get; }

        /// <summary>
        ///     Gets the supported <see cref="SpecificationType"/> for this analyzer.
        /// </summary>
        SpecificationType SpecificationType { get; }

        /// <summary>
        ///     Execute the semantic analysis.
        /// </summary>
        /// <param name="specification">The specification that is used for generating code.</param>
        /// <returns>A <see cref="Task{T}"/> whose result is the given <paramref name="specification"/>.</returns>
        Task<ISpecification> Execute(ISpecification specification);
    }
}
