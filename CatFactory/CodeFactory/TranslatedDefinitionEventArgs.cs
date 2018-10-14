using System;
using Microsoft.Extensions.Logging;

namespace CatFactory.CodeFactory
{
    /// <summary>
    /// Provides data for the <see cref="TranslatedDefinition"/> event
    /// </summary>
    public class TranslatedDefinitionEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of <see cref="TranslatedDefinitionEventArgs"/> class
        /// </summary>
        /// <param name="logger">Instance of <see cref="Logger"/> class</param>
        public TranslatedDefinitionEventArgs(ILogger logger)
        {
            Logger = logger;
        }

        /// <summary>
        /// Gets the <see cref="Logger"/> instance
        /// </summary>
        public ILogger Logger { get; }
    }
}
