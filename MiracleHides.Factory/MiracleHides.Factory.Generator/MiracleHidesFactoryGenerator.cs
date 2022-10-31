namespace MiracleHides.Factory.Generator
{
    using System.IO;
    using MiracleHides.Factory.Generator.Contracts;
    using MiracleHides.Factory.Generator.Contracts.LexicalAnalysis;

    /// <summary>
    ///     Describes the operations of a software generator.
    /// </summary>
    internal class MiracleHidesFactoryGenerator : IMiracleHidesFactoryGenerator
    {
        /// <summary>
        ///     Lexical analysis of the code generator.
        /// </summary>
        private readonly ILexer lexer;

        /// <summary>
        ///     Create a new instance of <see cref="MiracleHidesFactoryGenerator"/>.
        /// </summary>
        /// <param name="lexer">An instance for executing the lexical analysis.</param>
        public MiracleHidesFactoryGenerator(ILexer lexer)
        {
            this.lexer = lexer;
        }

        /// <summary>
        ///     Generate source code for the given <paramref name="jsonFileName"/> specification.
        /// </summary>
        /// <param name="jsonFileName">The path of the json file.</param>
        /// <returns>The source code as <see cref="byte[]"/> in zip format.</returns>
        public byte[] Generate(string jsonFileName)
        {
            var content = File.ReadAllText(jsonFileName);
            return this.Run(content);
        }

        /// <summary>
        ///     Generate source code for the given <paramref name="jsonContent"/> specification.
        /// </summary>
        /// <param name="jsonContent">The specification in json format.</param>
        /// <returns>The source code as <see cref="byte[]"/> in zip format.</returns>
        private byte[] Run(string jsonContent)
        {
            this.lexer.Execute(jsonContent);
            return new byte[0];
        }
    }
}
