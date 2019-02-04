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
        /// <summary>
        /// Initializes a new instance of <see cref="FinalizerDefinition"/> class
        /// </summary>
        public FinalizerDefinition()
        {
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<ILine> m_lines;

        /// <summary>
        /// Gets or sets the method body
        /// </summary>
        public List<ILine> Lines
        {
            get
            {
                return m_lines ?? (m_lines = new List<ILine>());
            }
            set
            {
                m_lines = value;
            }
        }
    }
}
