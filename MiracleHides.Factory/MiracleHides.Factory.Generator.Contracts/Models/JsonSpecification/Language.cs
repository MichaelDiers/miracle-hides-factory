namespace MiracleHides.Factory.Generator.Contracts.Models.JsonSpecification
{
    /// <summary>
    ///     The supported languages for generating source code.
    /// </summary>
    public enum Language
    {
        /// <summary>
        ///     The language is not specified.
        /// </summary>
        None = 0,

        /// <summary>
        ///     Generate c# code.
        /// </summary>
        CSharp = 1,

        /// <summary>
        ///     Generate code for NodeJs.
        /// </summary>
        NodeJs = 2,

        /// <summary>
        ///     Generate code for NestJs.
        /// </summary>
        NestJs = 3,

        /// <summary>
        ///     Generate code for python.
        /// </summary>
        Python = 4
    }
}
