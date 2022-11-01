namespace MiracleHides.Factory.Generator.Analysis
{
    using System.Threading.Tasks;
    using MiracleHides.Factory.Generator.Contracts.Models.JsonSpecification;

    /// <summary>
    ///     The semantic analysis of the c# crud code generator.
    /// </summary>
    internal class CrudCSharpSemanticAnalysis : CSharpSemanticAnalysis
    {
        /// <summary>
        /// Create a new instance of the <see cref="CrudCSharpSemanticAnalysis"/> class.
        /// </summary>
        public CrudCSharpSemanticAnalysis()
            : base(SpecificationType.Crud)
        {
        }

        /// <summary>
        ///     Execute the semantic analysis for c#.
        /// </summary>
        /// <param name="specification">The specification that is used for generating code.</param>
        /// <returns>A <see cref="Task{T}"/> whose result is the given <paramref name="specification"/>.</returns>
        public async override Task<ISpecification> Execute(ISpecification specification)
        {
            return await base.Execute(specification);
        }
    }
}
