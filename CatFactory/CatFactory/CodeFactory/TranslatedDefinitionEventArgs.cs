using System;
using Microsoft.Extensions.Logging;

namespace CatFactory.CodeFactory
{
    public class TranslatedDefinitionEventArgs : EventArgs
    {
        public TranslatedDefinitionEventArgs(ILogger logger)
        {
            Logger = logger;
        }

        public ILogger Logger { get; }
    }
}
