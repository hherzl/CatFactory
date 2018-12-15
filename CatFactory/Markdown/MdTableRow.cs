using System.Collections.Generic;
using System.Diagnostics;

namespace CatFactory.Markdown
{
    /// <summary>
    /// 
    /// </summary>
    public class MdTableRow
    {
        /// <summary>
        /// 
        /// </summary>
        public MdTableRow()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cells"></param>
        public MdTableRow(params string[] cells)
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
