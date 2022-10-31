namespace MiracleHides.Factory.Generator.Test
{
    using Microsoft.Extensions.DependencyInjection;
    using MiracleHides.Factory.Generator.Extensions;

    /// <summary>
    ///     Initialize the test dependencies.
    /// </summary>
    public class Startup
    { 
        /// <summary>
        ///     Add test dependencies.
        /// </summary>
        /// <param name="services">An <see cref="IServiceCollection"/>.</param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMiracleHidesFactoryGenerator();
        }
    }
}
