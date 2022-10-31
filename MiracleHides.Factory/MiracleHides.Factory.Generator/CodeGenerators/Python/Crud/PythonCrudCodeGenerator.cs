namespace MiracleHides.Factory.Generator.CodeGenerators.Python.Crud
{
    using System.Threading.Tasks;
    using MiracleHides.Factory.Generator.Contracts.Models.JsonSpecification;

    /// <summary>
    ///     A code generator for python.
    /// </summary>
    internal class PythonCrudCodeGenerator : PythonCodeGenerator
    {
        /// <summary>
        ///     Create a new instance of the <see cref="PythonCrudCodeGenerator"/> class.
        /// </summary>
        public PythonCrudCodeGenerator()
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
