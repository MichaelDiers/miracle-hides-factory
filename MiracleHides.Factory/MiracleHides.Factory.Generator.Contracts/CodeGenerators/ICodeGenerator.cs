namespace MiracleHides.Factory.Generator.Contracts.CodeGenerators
{
    using System.Threading.Tasks;
    using MiracleHides.Factory.Generator.Contracts.Models.JsonSpecification;

    /// <summary>
    ///     Describes a source code generator for a specific <see cref="Language"/>.
    /// </summary>
    public interface ICodeGenerator
    {
        /// <summary>
        ///     Gets the language for that source code is generated.
        /// </summary>
        Language Language { get; }

        /// <summary>
        ///     Gets the type specification, like a crud api.
        /// </summary>
        SpecificationType SpecificationType { get; }

        /// <summary>
        ///     Generate source code for the given <see cref="ISpecification"/>.
        /// </summary>
        /// <param name="specification">The specification from that code is generated.</param>
        /// <returns>A <see cref="Task{T}"/> whose result is a <see cref="byte[]"/> that contains the files in zip format.</returns>
        Task<byte[]> Generate(ISpecification specification);
    }
}
