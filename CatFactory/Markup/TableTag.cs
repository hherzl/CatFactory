using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace CatFactory.Markup
{
#pragma warning disable CS1591
    public class TableTag : Tag
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TableHeadTag m_head;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<TableRowTag> m_rows;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TableFootTag m_foot;

        public TableTag()
            : base()
        {
        }

        public TableHeadTag Head
        {
            get => m_head ??= new TableHeadTag();
            set => m_head = value;
        }

        public List<TableRowTag> Rows
        {
            get => m_rows ??= new List<TableRowTag>();
            set => m_rows = value;
        }

        public TableFootTag Footer
        {
            get => m_foot ??= new TableFootTag();
            set => m_foot = value;
        }

        public override string ToString()
        {
            var output = new StringBuilder();

            var name = HasNamespace ? string.Format("{0}:{1}", Namespace, Name) : Name;

            var attributes = Attributes.Count == 0 ? string.Empty : string.Join(" ", Attributes.Select(item => string.Format("{0}=\"{1}\"", item.Name, item.Value)));

            output.AppendFormat("<{0} {1}>", name, attributes);
            output.AppendLine();

            output.AppendLine("<thead>");
            output.AppendLine("<tr>");

            foreach (var cell in Head.Cells)
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

            output.AppendLine("<tfoot>");
            output.AppendLine("<tr>");

            foreach (var cell in Footer.Cells)
            {
                output.AppendFormat("<td>{0}</td>", cell.Text);
                output.AppendLine();
            }

            output.AppendLine("</tr>");
            output.AppendLine("</tfoot>");

            output.AppendLine("</table>");

            return output.ToString();
        }
    }
}
