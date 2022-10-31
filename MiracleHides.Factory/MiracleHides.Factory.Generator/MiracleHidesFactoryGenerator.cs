namespace MiracleHides.Factory.Generator
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;
    using MiracleHides.Factory.Generator.Contracts;
    using MiracleHides.Factory.Generator.Contracts.CodeGenerators;
    using MiracleHides.Factory.Generator.Contracts.LexicalAnalysis;

    /// <summary>
    ///     Describes the operations of a software generator.
    /// </summary>
    internal class MiracleHidesFactoryGenerator : IMiracleHidesFactoryGenerator
    {
        /// <summary>
        ///     All available code generators.
        /// </summary>
        private readonly IEnumerable<ICodeGenerator> codeGenerators;

        /// <summary>
        ///     Lexical analysis of the code generator.
        /// </summary>
        private readonly ILexer lexer;

        /// <summary>
        ///     Create a new instance of <see cref="MiracleHidesFactoryGenerator"/>.
        /// </summary>
        /// <param name="lexer">An instance for executing the lexical analysis.</param>
        /// <param name="codeGenerators">All available code generators.</param>
        public MiracleHidesFactoryGenerator(ILexer lexer, IEnumerable<ICodeGenerator> codeGenerators)
        {
            this.lexer = lexer;
            this.codeGenerators = codeGenerators;
        }

        /// <summary>
        ///     Generate source code for the given <paramref name="jsonFileName"/> specification.
        /// </summary>
        /// <param name="jsonFileName">The path of the json file.</param>
        /// <returns>A <see cref="Task{T}"/> whose result is the source code as <see cref="byte[]"/> in zip format.</returns>
        public async Task<byte[]> Generate(string jsonFileName)
        {
            var content = File.ReadAllText(jsonFileName);
            var zippedCode = await this.Run(content);
            return zippedCode;
        }

        /// <summary>
        ///     Generate source code for the given <paramref name="jsonContent"/> specification.
        /// </summary>
        /// <param name="jsonContent">The specification in json format.</param>
        /// <returns>The source code as <see cref="byte[]"/> in zip format.</returns>
        private async Task<byte[]> Run(string jsonContent)
        {
            var specification = await this.lexer.Execute(jsonContent);

            var codeGenerator = this.codeGenerators.FirstOrDefault(generator => generator.Language == specification.Language && generator.SpecificationType == specification.Type);
            if (codeGenerator == null)
            {
                throw new Exception("Unsupported language or specification type.");
            }

            var zippedCode = await codeGenerator.Generate(specification);
            return zippedCode;
        }
    }
}
