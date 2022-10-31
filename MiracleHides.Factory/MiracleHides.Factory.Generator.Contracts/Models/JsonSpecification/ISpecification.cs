namespace MiracleHides.Factory.Generator.Contracts.Models.JsonSpecification
{
    /// <summary>
    ///     Describes the input specification from that source code is generated.
    /// </summary>
    public interface ISpecification
    {
        /// <summary>
        ///     Specifies the target language of the generated source code.
        /// </summary>
        Language Language { get; }
     
        /// <summary>
        ///     Specifies the type of the generated code, like a CRUD api.
        /// </summary>
        SpecificationType Type { get; }
    }
}
