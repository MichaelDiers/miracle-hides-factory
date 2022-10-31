namespace MiracleHides.Factory.Generator.CodeGenerators.CSharp
{
    using MiracleHides.Factory.Generator.Contracts.Models.JsonSpecification;

    /// <summary>
    ///     A code generator for c#.
    /// </summary>
    internal abstract class CSharpCodeGenerator : CodeGenerator
    {
        /// <summary>
        ///     Create a new instance of the <see cref="CSharpCodeGenerator"/> class.
        /// </summary>
        /// <param name="specificationType">The type of the genrated source code, like a crud api.</param>
        protected CSharpCodeGenerator(SpecificationType type) 
            : base(Language.CSharp, type)
        {
        }        
    }
}
