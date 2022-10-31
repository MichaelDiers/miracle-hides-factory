namespace MiracleHides.Factory.Generator.CodeGenerators.NodeJs
{
    using MiracleHides.Factory.Generator.Contracts.Models.JsonSpecification;

    /// <summary>
    ///     A code generator for NodeJs.
    /// </summary>
    internal abstract class NodeJsCodeGenerator : CodeGenerator
    {
        /// <summary>
        ///     Create a new instance of the <see cref="NodeJsCodeGenerator"/> class.
        /// </summary>
        /// <param name="specificationType">The type of the genrated source code, like a crud api.</param>
        protected NodeJsCodeGenerator(SpecificationType specificationType) 
            : base(Language.NodeJs, specificationType)
        {
        }
    }
}
