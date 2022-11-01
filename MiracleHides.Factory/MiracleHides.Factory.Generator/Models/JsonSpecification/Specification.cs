namespace MiracleHides.Factory.Generator.Models.JsonSpecification
{
    using System.Text.Json.Serialization;
    using MiracleHides.Factory.Generator.Contracts.Models.JsonSpecification;

    /// <summary>
    ///     Describes the input specification from that source code is generated.
    /// </summary>
    public class Specification : ISpecification
    {
        /// <summary>
        ///     Gets or sets the name of folder to that the source code is generated.
        /// </summary>
        /// <remarks>Scope: Global</remarks>
        public string Folder { get; set; } = "";

        /// <summary>
        ///     Specifies the target language of the generated source code.
        /// </summary>
        public Language Language { get; set; }

        /// <summary>
        ///     Gets or sets the name of the csharp project file.
        /// </summary>
        /// <remarks>Scope: CSharp</remarks>
        public string? ProjectName { get; set; }

        /// <summary>
        ///     Gets or sets the name of the csharp solution file.
        /// </summary>
        /// <remarks>Scope: CSharp</remarks>
        public string? SolutionName { get; set; }

        /// <summary>
        ///     Specifies the type of the generated code, like a CRUD api.
        /// </summary>
        [JsonPropertyName("type")]
        public SpecificationType Type { get; set; }

        /// <summary>
        ///     Gets or sets the name of the csharp test project file.
        /// </summary>
        /// <remarks>Scope: CSharp</remarks>
        public string? TestProjectName { get; set; }
    }
}
