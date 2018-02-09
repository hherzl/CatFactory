using System;
using Microsoft.Extensions.Logging;

namespace CatFactory.CodeFactory
{
    public class ScaffoldedDefinitionEventArgs : EventArgs
    {
        public ScaffoldedDefinitionEventArgs(ILogger logger, ICodeBuilder codeBuilder)
        {
            Logger = logger;
            CodeBuilder = codeBuilder;
        }

        public ILogger Logger { get; }

        public ICodeBuilder CodeBuilder { get; }
    }
}
