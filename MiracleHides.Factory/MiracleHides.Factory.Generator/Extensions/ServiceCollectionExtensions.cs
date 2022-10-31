namespace MiracleHides.Factory.Generator.Extensions
{
    using Microsoft.Extensions.DependencyInjection;
    using MiracleHides.Factory.Generator;
    using MiracleHides.Factory.Generator.Contracts;
    using MiracleHides.Factory.Generator.Contracts.LexicalAnalysis;
    using MiracleHides.Factory.Generator.LexicalAnalysis;    

    /// <summary>
    ///     Extensions for <see cref="IServiceCollection"/>.
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        ///     Add dependencies to the <see cref="IServiceCollection"/>.
        /// </summary>
        /// <param name="serviceCollection">Dependencies are added to this <see cref="IServiceCollection"/>.</param>
        public static void AddMiracleHidesFactoryGenerator(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<ILexer, Lexer>();
            serviceCollection.AddScoped<IMiracleHidesFactoryGenerator, MiracleHidesFactoryGenerator>();
        }
    }
}
