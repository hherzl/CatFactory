using System.Collections.Generic;
using System.Diagnostics;
using CatFactory.CodeFactory;

namespace CatFactory.ObjectOrientedProgramming
{
    /// <summary>
    /// Represents a definition for Finalizer in Object Oriented Programming context
    /// </summary>
    public class FinalizerDefinition
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private List<ILine> m_lines;

        /// <summary>
        /// Initializes a new instance of <see cref="FinalizerDefinition"/> class
        /// </summary>
        public FinalizerDefinition()
        {
        }

        /// <summary>
        /// Gets or sets the method body
        /// </summary>
        public List<ILine> Lines
        {
            get => m_lines ?? (m_lines = new List<ILine>());
            set => m_lines = value;
        }
    }
}
