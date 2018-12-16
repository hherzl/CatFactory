using System.Collections.Generic;
using System.Diagnostics;

namespace CatFactory.Markup
{
    /// <summary>
    /// 
    /// </summary>
    public class TableHeaderTag : Tag
    {
        /// <summary>
        /// 
        /// </summary>
        public TableHeaderTag()
        {
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<TableCellTag> m_cells;

        /// <summary>
        /// 
        /// </summary>
        public List<TableCellTag> Cells
        {
            get
            {
                return m_cells ?? (m_cells = new List<TableCellTag>());
            }
            set
            {
                m_cells = value;
            }
        }
    }
}
