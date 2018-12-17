using System.Collections.Generic;
using System.Diagnostics;

namespace CatFactory.Markdown
{
    /// <summary>
    /// 
    /// </summary>
    public class MdTable
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static MdTable Create()
        {
            return new MdTable();
        }

        /// <summary>
        /// 
        /// </summary>
        public MdTable()
        {
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private MdTableHeader m_headers;

        /// <summary>
        /// 
        /// </summary>
        public MdTableHeader Header
        {
            get
            {
                return m_headers ?? (m_headers = new MdTableHeader());
            }
            set
            {
                m_headers = value;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<MdTableRow> m_rows;

        /// <summary>
        /// 
        /// </summary>
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
}
