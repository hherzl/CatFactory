using System.Collections.Generic;
using System.Diagnostics;

namespace CatFactory.Markup
{
#pragma warning disable CS1591
    public class TableRowTag : Tag
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<TableCellTag> m_cells;

        public TableRowTag()
            : base()
        {
        }

        public TableRowTag(params string[] cells)
        {
            foreach (var item in cells)
            {
                Cells.Add(new TableCellTag(item));
            }
        }

        public List<TableCellTag> Cells
        {
            get => m_cells ??= new List<TableCellTag>();
            set => m_cells = value;
        }
    }
}
