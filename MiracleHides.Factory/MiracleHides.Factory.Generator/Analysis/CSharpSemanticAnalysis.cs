namespace MiracleHides.Factory.Generator.Analysis
{
    using System;
    using System.Text.Json;
    using System.Threading.Tasks;
    using MiracleHides.Factory.Generator.Contracts.Models.JsonSpecification;

    /// <summary>
    ///     The semantic analysis of the c# code generator.
    /// </summary>
    internal class CSharpSemanticAnalysis : SemanticAnalysis
    {
        /// <summary>
        /// Create a new instance of the <see cref="CSharpSemanticAnalysis"/> class.
        /// </summary>
        /// <param name="specificationType">The specification type for that the analysis is executed.</param>
        protected CSharpSemanticAnalysis(SpecificationType specificationType)
            : base(Language.CSharp, specificationType)
        {
        }

        /// <summary>
        ///     Execute the semantic analysis for c#.
        /// </summary>
        /// <param name="specification">The specification that is used for generating code.</param>
        /// <returns>A <see cref="Task{T}"/> whose result is the given <paramref name="specification"/>.</returns>
        public async override Task<ISpecification> Execute(ISpecification specification)
        {
            var checks = new[]
            {
                (check: new Func<ISpecification, string>(spec => spec.SolutionName), name: nameof(ISpecification.SolutionName)),
                (check: new Func<ISpecification, string>(spec => spec.ProjectName), name: nameof(ISpecification.ProjectName)),
                (check: new Func<ISpecification, string>(spec => spec.TestProjectName), name: nameof(ISpecification.TestProjectName)),
            };

            foreach (var check in checks)
            {
                if (string.IsNullOrWhiteSpace(check.check(specification)))
                {
                    throw new JsonException($"{check.name} is null or whitespace.");
                }
            }

            return await base.Execute(specification);
        }
    }
}
