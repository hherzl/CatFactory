using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace CatFactory
{
    /// <summary>
    /// Provides helper methods for Logging features
    /// </summary>
    public static class LoggingHelper
    {
        /// <summary>
        /// Gets an instance of <see cref="Logger"/> class for supplied type
        /// </summary>
        /// <typeparam name="TModel">Type to log</typeparam>
        /// <returns>An instance of <see cref="Logger{TModel}"/></returns>
        public static ILogger<TModel> GetLogger<TModel>()
            => new ServiceCollection()
                .AddLogging()
                .BuildServiceProvider()
                .GetService<ILoggerFactory>()
                .CreateLogger<TModel>();
    }
}
