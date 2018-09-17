using System;
using Microsoft.Extensions.Logging;

namespace CatFactory.CodeFactory
{
    /// <summary>
    /// 
    /// </summary>
    public class TranslatedDefinitionEventArgs : EventArgs
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="logger"></param>
        public TranslatedDefinitionEventArgs(ILogger logger)
        {
            Logger = logger;
        }

        /// <summary>
        /// 
        /// </summary>
        public ILogger Logger { get; }
    }
}
