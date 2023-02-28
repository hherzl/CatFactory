using System.Collections.Generic;
using System.Diagnostics;

namespace CatFactory.Markdown
{
    /// <summary>
    /// Represents a table row for markdown language
    /// </summary>
    /// <remarks>For more info: https://en.wikipedia.org/wiki/Markdown</remarks>
    public class MdTableRow
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<string> m_cells;

        /// <summary>
        /// Initializes a new instance of <see cref="MdTableRow"/> class
        /// </summary>
        public MdTableRow()
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="MdTableRow"/> class
        /// </summary>
        /// <param name="cells"></param>
        public MdTableRow(params string[] cells)
        {
            Cells.AddRange(cells);
        }

        /// <summary>
        /// Gets or sets the cells for current table row
        /// </summary>
        public List<string> Cells
        {
            get => m_cells ??= new List<string>();
            set => m_cells = value;
        }
    }
}
