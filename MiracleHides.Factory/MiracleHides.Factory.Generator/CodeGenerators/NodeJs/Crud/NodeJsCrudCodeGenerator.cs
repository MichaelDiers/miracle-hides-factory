namespace MiracleHides.Factory.Generator.CodeGenerators.NodeJs.Crud
{
    using System.Threading.Tasks;
    using MiracleHides.Factory.Generator.Contracts.Models.JsonSpecification;

    /// <summary>
    ///     A code generator for NodeJs crud api.
    /// </summary>
    internal class NodeJsCrudCodeGenerator : NodeJsCodeGenerator
    {
        /// <summary>
        ///     Create a new instance of the <see cref="NodeJsCrudCodeGenerator"/> class.
        /// </summary>
        public NodeJsCrudCodeGenerator() 
            : base(SpecificationType.Crud)
        {
        }

        /// <summary>
        ///     Generate source code for the given <see cref="ISpecification"/>.
        /// </summary>
        /// <param name="specification">The specification from that code is generated.</param>
        /// <returns>A <see cref="Task{T}"/> whose result is a <see cref="byte[]"/> that contains the files in zip format.</returns>
        public override Task<byte[]> Generate(ISpecification specification)
        {
            return Task.FromResult(new byte[0]);
        }
    }
}
