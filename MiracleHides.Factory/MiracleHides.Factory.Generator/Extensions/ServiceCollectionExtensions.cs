namespace MiracleHides.Factory.Generator.Extensions
{
    using Microsoft.Extensions.DependencyInjection;
    using MiracleHides.Factory.Generator;
    using MiracleHides.Factory.Generator.Analysis;
    using MiracleHides.Factory.Generator.CodeGenerators.CSharp.Crud;
    using MiracleHides.Factory.Generator.CodeGenerators.NestJs.Crud;
    using MiracleHides.Factory.Generator.CodeGenerators.NodeJs.Crud;
    using MiracleHides.Factory.Generator.CodeGenerators.Python.Crud;
    using MiracleHides.Factory.Generator.Contracts;
    using MiracleHides.Factory.Generator.Contracts.Analysis;
    using MiracleHides.Factory.Generator.Contracts.CodeGenerators;

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
            serviceCollection.AddScoped<ILexicalAnalysis, LexicalAnalysis>();
            serviceCollection.AddScoped<ISemanticAnalysis, CrudCSharpSemanticAnalysis>();
            serviceCollection.AddScoped<ICodeGenerator, CSharpCrudCodeGenerator>();
            serviceCollection.AddScoped<ICodeGenerator, NestJsCrudCodeGenerator>();
            serviceCollection.AddScoped<ICodeGenerator, NodeJsCrudCodeGenerator>();
            serviceCollection.AddScoped<ICodeGenerator, PythonCrudCodeGenerator>();
            serviceCollection.AddScoped<IMiracleHidesFactoryGenerator, MiracleHidesFactoryGenerator>();
        }
    }
}
