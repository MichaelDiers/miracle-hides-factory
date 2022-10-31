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
        ///     Specifies the target language of the generated source code.
        /// </summary>
        public Language Language { get; set; }
     
        /// <summary>
        ///     Specifies the type of the generated code, like a CRUD api.
        /// </summary>
        [JsonPropertyName("type")]
        public SpecificationType Type { get; set; }
    }
}
