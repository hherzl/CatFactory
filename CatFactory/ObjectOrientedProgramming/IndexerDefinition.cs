using System.Collections.Generic;
using System.Diagnostics;
using CatFactory.CodeFactory;

namespace CatFactory.ObjectOrientedProgramming
{
    /// <summary>
    /// Represents a definition for Indexer in Object Oriented Programming context
    /// </summary>
    public class IndexerDefinition : IMemberDefinition
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<ParameterDefinition> m_parameters;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<ILine> m_getBody;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<ILine> m_setBody;

        /// <summary>
        /// Initializes a new instance of <see cref="IndexerDefinition"/> class
        /// </summary>
        public IndexerDefinition()
        {
        }

        /// <summary>
        /// Gets or sets the access modifier for current indexer definition
        /// </summary>
        public AccessModifier AccessModifier { get; set; }

        /// <summary>
        /// Gets or sets the type for current indexer definition
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the name for current indexer definition
        /// </summary>
        public string Name { get; set; } = "this";

        /// <summary>
        /// Gets or sets the parameters for current indexer definition
        /// </summary>
        public List<ParameterDefinition> Parameters
        {
            get => m_parameters ??= new List<ParameterDefinition>();
            set => m_parameters = value;
        }

        /// <summary>
        /// Gets or sets the get body for current indexer definition
        /// </summary>
        public List<ILine> GetBody
        {
            get => m_getBody ??= new List<ILine>();
            set => m_getBody = value;
        }

        /// <summary>
        /// Gets or sets the set body for current indexer definition
        /// </summary>
        public List<ILine> SetBody
        {
            get => m_setBody ??= new List<ILine>();
            set => m_setBody = value;
        }
    }
}
