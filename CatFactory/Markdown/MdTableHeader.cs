using System.Collections.Generic;
using System.Diagnostics;

namespace CatFactory.Markdown
{
    /// <summary>
    /// Represents a table header for markdown language
    /// </summary>
    /// <remarks>For more info: https://en.wikipedia.org/wiki/Markdown</remarks>
    public class MdTableHeader
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<string> m_cells;

        /// <summary>
        /// Initializes a new instance of <see cref="MdTableHeader"/> class
        /// </summary>
        public MdTableHeader()
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="MdTableHeader"/> class
        /// </summary>
        /// <param name="cells">Cells for table header</param>
        public MdTableHeader(params string[] cells)
        {
            Cells.AddRange(cells);
        }

        /// <summary>
        /// Gets or sets the cells for current table header
        /// </summary>
        public List<string> Cells
        {
            get => m_cells ??= new List<string>();
            set => m_cells = value;
        }
    }
}
