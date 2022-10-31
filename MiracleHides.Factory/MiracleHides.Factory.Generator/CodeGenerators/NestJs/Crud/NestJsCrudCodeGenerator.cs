namespace MiracleHides.Factory.Generator.CodeGenerators.NestJs.Crud
{
    using System.Threading.Tasks;
    using MiracleHides.Factory.Generator.Contracts.Models.JsonSpecification;

    /// <summary>
    ///     A code generator for NestJs crud api.
    /// </summary>
    internal class NestJsCrudCodeGenerator : NestJsCodeGenerator
    {
        /// <summary>
        ///     Create a new instance of the <see cref="NestJsCrudCodeGenerator"/> class.
        /// </summary>
        public NestJsCrudCodeGenerator() 
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
