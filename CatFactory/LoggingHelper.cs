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
        /// <param name="addTrace">Add trace level for <see cref="Logger"/> instance</param>
        /// <param name="addDebug">Add debug level for <see cref="Logger"/> instance</param>
        /// <param name="addInformation">Add information level for <see cref="Logger"/> instance</param>
        /// <param name="addWarning">Add warning level for <see cref="Logger"/> instance</param>
        /// <param name="addError">Add error level for <see cref="Logger"/> instance</param>
        /// <param name="addCritical">Add critical level for <see cref="Logger"/> instance</param>
        /// <returns></returns>
        public static ILogger<TModel> GetLogger<TModel>(bool addTrace = true, bool addDebug = true, bool addInformation = true, bool addWarning = true, bool addError = true, bool addCritical = true)
        {
            var serviceProvider = new ServiceCollection()
                .AddLogging()
                .BuildServiceProvider();

            var service = serviceProvider
                .GetService<ILoggerFactory>();

            if (addTrace)
                service.AddConsole(LogLevel.Trace);

            if (addDebug)
                service.AddConsole(LogLevel.Debug);

            if (addInformation)
                service.AddConsole(LogLevel.Information);

            if (addWarning)
                service.AddConsole(LogLevel.Warning);

            if (addError)
                service.AddConsole(LogLevel.Error);

            if (addCritical)
                service.AddConsole(LogLevel.Critical);

            return serviceProvider
                .GetService<ILoggerFactory>()
                .CreateLogger<TModel>();
        }
    }
}
