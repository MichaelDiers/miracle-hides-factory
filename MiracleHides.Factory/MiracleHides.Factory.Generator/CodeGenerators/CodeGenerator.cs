namespace MiracleHides.Factory.Generator.CodeGenerators
{
    using System.Threading.Tasks;
    using MiracleHides.Factory.Generator.Contracts.CodeGenerators;
    using MiracleHides.Factory.Generator.Contracts.Models.JsonSpecification;

    /// <summary>
    ///     Describes a source code generator for a specific <see cref="Language"/>.
    /// </summary>
    internal abstract class CodeGenerator : ICodeGenerator
    {
        /// <summary>
        ///     Create a new instance of the <see cref="CodeGenerator"/> class.
        /// </summary>
        /// <param name="language"></param>
        /// <param name="specificationType">The type of the genrated source code, like a crud api.</param>
        protected CodeGenerator(Language language, SpecificationType specificationType)            
        {
            this.Language = language;
            this.SpecificationType = specificationType;
        }

        /// <summary>
        ///     Gets the language for that source code is generated.
        /// </summary>
        public Language Language { get; }

        /// <summary>
        ///     Gets the type specification, like a crud api.
        /// </summary>
        public SpecificationType SpecificationType { get; }

        /// <summary>
        ///     Generate source code for the given <see cref="ISpecification"/>.
        /// </summary>
        /// <param name="specification">The specification from that code is generated.</param>
        /// <returns>A <see cref="Task{T}"/> whose result is a <see cref="byte[]"/> that contains the files in zip format.</returns>
        public abstract Task<byte[]> Generate(ISpecification specification);
    }
}
