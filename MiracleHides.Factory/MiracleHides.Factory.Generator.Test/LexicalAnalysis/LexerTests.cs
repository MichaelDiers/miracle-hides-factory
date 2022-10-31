namespace MiracleHides.Factory.Generator.Test.LexicalAnalysis
{
    using Xunit;
    using System.IO;
    using MiracleHides.Factory.Generator.Contracts.LexicalAnalysis;
    using System.Threading.Tasks;

    /// <summary>
    ///     Tests for <see cref="ILexer"/>.
    /// </summary>
    public class LexerTests
    {
        /// <summary>
        ///     The lexer for that tests are executed.
        /// </summary>
        private readonly ILexer lexer;

        /// <summary>
        ///     Initialize the tests dependencies.
        /// </summary>
        /// <param name="lexer"></param>
        public LexerTests(ILexer lexer)
        {
            this.lexer = lexer;
        }

        /// <summary>
        ///     Execute the lexer.
        /// </summary>
        [Theory]
        [InlineData("examples/crud/csharp.json")]
        [InlineData("examples/crud/nestjs.json")]
        [InlineData("examples/crud/nodejs.json")]
        [InlineData("examples/crud/python.json")]
        public async Task Execute(string jsonFileName)
        {
            string content = File.ReadAllText(jsonFileName);
            await this.lexer.Execute(content);
        }
    }
}
