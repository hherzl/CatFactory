using System.Collections.Generic;
using System.Diagnostics;

namespace CatFactory.Markup
{
#pragma warning disable CS1591
    public class TableHeadTag : Tag
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<TableCellTag> _cells;

        public TableHeadTag()
            : base()
        {
        }

        public List<TableCellTag> Cells
        {
            get => _cells ?? (_cells = new List<TableCellTag>());
            set => _cells = value;
        }
    }
}
