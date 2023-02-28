using System.Collections.Generic;
using System.Diagnostics;

namespace CatFactory.Markup
{
#pragma warning disable CS1591
    public class TableHeadTag : Tag
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<TableCellTag> m_cells;

        public TableHeadTag()
            : base()
        {
        }

        public List<TableCellTag> Cells
        {
            get => m_cells ??= new List<TableCellTag>();
            set => m_cells = value;
        }
    }
}
