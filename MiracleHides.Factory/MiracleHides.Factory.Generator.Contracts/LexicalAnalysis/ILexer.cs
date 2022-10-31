﻿namespace MiracleHides.Factory.Generator.Contracts.LexicalAnalysis
{
    using System.Threading.Tasks;
    using MiracleHides.Factory.Generator.Contracts.Models.JsonSpecification;
    
    /// <summary>
    ///     Describes the operations of the lixical analysis.
    /// </summary>
    public interface ILexer
    {
        /// <summary>
        ///     Execute the lexical analysis.
        /// </summary>
        /// <param name="content">The specification in json file format.</param>
        /// <returns>A <see cref="Task{T}"/> whose result is a parsed <see cref="ISpecification"/>.</returns>
        Task<ISpecification> Execute(string content);
    }
}
