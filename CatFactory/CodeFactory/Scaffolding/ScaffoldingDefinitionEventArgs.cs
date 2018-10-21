using System;
using Microsoft.Extensions.Logging;

namespace CatFactory.CodeFactory.Scaffolding
{
    /// <summary>
    /// Provides data for the <see cref="ScaffoldingDefinition"/> event
    /// </summary>
    public class ScaffoldingDefinitionEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of <see cref="ScaffoldingDefinitionEventArgs"/> class
        /// </summary>
        /// <param name="logger">Instance of <see cref="Logger"/> class</param>
        /// <param name="codeBuilder">Instance of class <see cref="CodeBuilder"/> class</param>
        public ScaffoldingDefinitionEventArgs(ILogger logger, ICodeBuilder codeBuilder)
        {
            Logger = logger;
            CodeBuilder = codeBuilder;
        }

        /// <summary>
        /// Gets the instance of <see cref="Logger"/> class
        /// </summary>
        public ILogger Logger { get; }

        /// <summary>
        /// Gets the instance of class <see cref="CodeBuilder"/> class
        /// </summary>
        public ICodeBuilder CodeBuilder { get; }
    }
}
