namespace MiracleHides.Factory.Generator.CodeGenerators.Python
{
    using MiracleHides.Factory.Generator.Contracts.Models.JsonSpecification;

    /// <summary>
    ///     A code generator for python.
    /// </summary>
    internal abstract class PythonCodeGenerator : CodeGenerator
    {
        /// <summary>
        ///     Create a new instance of the <see cref="PythonCodeGenerator"/> class.
        /// </summary>
        /// <param name="specificationType">The type of the genrated source code, like a crud api.</param>
        protected PythonCodeGenerator(SpecificationType specificationType) 
            : base(Language.Python, specificationType)
        {
        }
    }
}
