using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace CatFactory.Markup
{
    /// <summary>
    /// 
    /// </summary>
    public class TableTag : Tag
    {
        /// <summary>
        /// 
        /// </summary>
        public TableTag()
        {
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TableHeaderTag m_header;

        /// <summary>
        /// 
        /// </summary>
        public TableHeaderTag Header
        {
            get
            {
                return m_header ?? (m_header = new TableHeaderTag());
            }
            set
            {
                m_header = value;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<TableRowTag> m_rows;

        /// <summary>
        /// 
        /// </summary>
        public List<TableRowTag> Rows
        {
            get
            {
                return m_rows ?? (m_rows = new List<TableRowTag>());
            }
            set
            {
                m_rows = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            var output = new StringBuilder();

            var name = HasNamespace ? string.Format("{0}:{1}", Namespace, Name) : Name;

            var attributes = Attributes.Count == 0 ? string.Empty : string.Join(" ", Attributes.Select(item => string.Format("{0}=\"{1}\"", item.Name, item.Value)));

            output.AppendFormat("<{0} {1}>", name, attributes);
            output.AppendLine();

            output.AppendLine("<thead>");

            output.AppendLine("<tr>");

            foreach (var cell in Header.Cells)
            {
                output.AppendFormat("<th>{0}</th>", cell.Text);
                output.AppendLine();
            }

            output.AppendLine("</tr>");

            output.AppendLine("</thead>");

            output.AppendLine("<tbody>");

            foreach (var row in Rows)
            {
                output.AppendLine("<tr>");

                foreach (var cell in row.Cells)
                {
                    output.AppendFormat("<td>{0}</td>", cell.Text);
                    output.AppendLine();
                }

                output.AppendLine("</tr>");
            }

            output.AppendLine("</tbody>");

            output.AppendLine("</table>");

            return output.ToString();
        }
    }
}
