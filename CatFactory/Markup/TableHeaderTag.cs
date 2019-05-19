using System.Collections.Generic;
using System.Diagnostics;

namespace CatFactory.Markup
{
    /// <summary>
    /// 
    /// </summary>
    public class TableHeaderTag : Tag
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private List<TableCellTag> m_cells;

        /// <summary>
        /// 
        /// </summary>
        public TableHeaderTag()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public List<TableCellTag> Cells
        {
            get => m_cells ?? (m_cells = new List<TableCellTag>());
            set => m_cells = value;
        }
    }
}
