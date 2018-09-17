using System;
using Microsoft.Extensions.Logging;

namespace CatFactory.CodeFactory
{
    /// <summary>
    /// 
    /// </summary>
    public class ScaffoldingDefinitionEventArgs : EventArgs
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="codeBuilder"></param>
        public ScaffoldingDefinitionEventArgs(ILogger logger, ICodeBuilder codeBuilder)
        {
            Logger = logger;
            CodeBuilder = codeBuilder;
        }

        /// <summary>
        /// 
        /// </summary>
        public ILogger Logger { get; }

        /// <summary>
        /// 
        /// </summary>
        public ICodeBuilder CodeBuilder { get; }
    }
}
