namespace MiracleHides.Factory.Generator.Contracts.Models.JsonSpecification
{
    /// <summary>
    ///     Describes the input specification from that source code is generated.
    /// </summary>
    public interface ISpecification
    {
        /// <summary>
        ///     Gets the name of folder to that the source code is generated.
        /// </summary>
        /// <remarks>Scope: Global</remarks>
        string Folder { get; }

        /// <summary>
        ///     Specifies the target language of the generated source code.
        /// </summary>
        /// <remarks>Scope: Global</remarks>
        Language Language { get; }

        /// <summary>
        ///     Gets the name of the csharp project file.
        /// </summary>
        /// <remarks>Scope: CSharp</remarks>
        string? ProjectName { get; }

        /// <summary>
        ///     Gets the name of the csharp solution file.
        /// </summary>
        /// <remarks>Scope: CSharp</remarks>
        string? SolutionName { get; }

        /// <summary>
        ///     Specifies the type of the generated code, like a CRUD api.
        /// </summary>
        /// <remarks>Scope: Global</remarks>
        SpecificationType Type { get; }

        /// <summary>
        ///     Gets the name of the csharp test project file.
        /// </summary>
        /// <remarks>Scope: CSharp</remarks>
        string? TestProjectName { get; }
    }
}
