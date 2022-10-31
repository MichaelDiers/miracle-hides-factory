namespace MiracleHides.Factory.Generator.CodeGenerators.NestJs
{
    using MiracleHides.Factory.Generator.Contracts.Models.JsonSpecification;

    /// <summary>
    ///     A code generator for NestJs.
    /// </summary>
    internal abstract class NestJsCodeGenerator : CodeGenerator
    {
        /// <summary>
        ///     Create a new instance of the <see cref="NestJsCodeGenerator"/> class.
        /// </summary>
        /// <param name="specificationType">The type of the genrated source code, like a crud api.</param>
        protected NestJsCodeGenerator(SpecificationType specificationType) 
            : base(Language.NestJs, specificationType)
        {
        }
    }
}
