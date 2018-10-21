using System.Collections.Generic;
using System.Diagnostics;
using CatFactory.CodeFactory;

namespace CatFactory.ObjectOrientedProgramming
{
    /// <summary>
    /// 
    /// </summary>
    public class FinalizerDefinition
    {
        /// <summary>
        /// 
        /// </summary>
        public FinalizerDefinition()
        {
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<ILine> m_lines;

        /// <summary>
        /// 
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
