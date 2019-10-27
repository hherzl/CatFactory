using System.Collections.Generic;
using System.Diagnostics;

namespace CatFactory.Markdown
{
    /// <summary>
    /// Represents a table for markdown language
    /// </summary>
    /// <remarks>For more info: https://en.wikipedia.org/wiki/Markdown</remarks>
    public class MdTable
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private MdTableHeader m_headers;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<MdTableRow> m_rows;

        /// <summary>
        /// Gets a new instance of <see cref="MdTable"/> class
        /// </summary>
        /// <returns>A new instance of table for markdown</returns>
        public static MdTable Create()
            => new MdTable();

        /// <summary>
        /// Initializes a new instance of <see cref="MdTable"/> class
        /// </summary>
        public MdTable()
        {
        }

        /// <summary>
        /// Gets or sets the header for current table
        /// </summary>
        public MdTableHeader Header
        {
            get => m_headers ?? (m_headers = new MdTableHeader());
            set => m_headers = value;
        }

        /// <summary>
        /// Gets or sets the rows for current table
        /// </summary>
        public List<MdTableRow> Rows
        {
            get => m_rows ?? (m_rows = new List<MdTableRow>());
            set => m_rows = value;
        }
    }
}
