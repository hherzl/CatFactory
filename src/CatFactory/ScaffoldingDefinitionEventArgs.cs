using System;
using CatFactory.CodeFactory;
using Microsoft.Extensions.Logging;

namespace CatFactory
{
    public class ScaffoldingDefinitionEventArgs : EventArgs
    {
        public ScaffoldingDefinitionEventArgs(ILogger logger, ICodeBuilder codeBuilder)
        {
            Logger = logger;
            CodeBuilder = codeBuilder;
        }

        public ILogger Logger { get; }

        public ICodeBuilder CodeBuilder { get; }
    }
}
