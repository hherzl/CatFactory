using System.Collections.Generic;
using System.Diagnostics;

namespace CatFactory.Markdown
{
    /// <summary>
    /// 
    /// </summary>
    public class MdTableHeader
    {
        /// <summary>
        /// 
        /// </summary>
        public MdTableHeader()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cells"></param>
        public MdTableHeader(params string[] cells)
        {
            Cells.AddRange(cells);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<string> m_cells;

        /// <summary>
        /// 
        /// </summary>
        public List<string> Cells
        {
            get
            {
                return m_cells ?? (m_cells = new List<string>());
            }
            set
            {
                m_cells = value;
            }
        }
    }
}
