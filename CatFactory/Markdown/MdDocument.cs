using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using CatFactory.CodeFactory;

namespace CatFactory.Markdown
{
    /// <summary>
    /// 
    /// </summary>
    public class MdDocument
    {
        /// <summary>
        /// 
        /// </summary>
        public MdDocument()
        {
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<ILine> m_lines;

        /// <summary>
        /// 
        /// </summary>
        public List<ILine> Lines
        {
            get
            {
                return m_lines ?? (m_lines = new List<ILine>());
            }
            set
            {
                m_lines = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            var output = new StringBuilder();

            for (var i = 0; i < Lines.Count; i++)
            {
                var line = Lines[i];

                if (i == Lines.Count - 1)
                    output.Append(line.ToString());
                else
                    output.AppendLine(line.ToString());
            }

            return output.ToString();
        }
    }

    public class MdTable
    {
        public static MdTable Create()
        {
            return new MdTable();
        }

        public MdTable()
        {
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<MdTableHeader> m_headers;

        public List<MdTableHeader> Headers
        {
            get
            {
                return m_headers ?? (m_headers = new List<MdTableHeader>());
            }
            set
            {
                m_headers = value;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<MdTableRow> m_rows;

        public List<MdTableRow> Rows
        {
            get
            {
                return m_rows ?? (m_rows = new List<MdTableRow>());
            }
            set
            {
                m_rows = value;
            }
        }
    }

    public class MdTableHeader
    {
        public MdTableHeader()
        {
        }

        public MdTableHeader(string text)
        {
            Text = text;
        }

        public string Text { get; set; }
    }

    public class MdTableRow
    {
        public MdTableRow()
        {
        }

        public MdTableRow(params string[] cells)
        {
            Cells.AddRange(cells);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<string> m_cells;

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
