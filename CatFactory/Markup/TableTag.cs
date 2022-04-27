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
        private TableHeadTag _head;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<TableRowTag> _rows;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private TableFootTag _foot;

        public TableTag()
            : base()
        {
        }

        public TableHeadTag Head
        {
            get => _head ?? (_head = new TableHeadTag());
            set => _head = value;
        }

        public List<TableRowTag> Rows
        {
            get => _rows ?? (_rows = new List<TableRowTag>());
            set => _rows = value;
        }

        public TableFootTag Foot
        {
            get => _foot ?? (_foot = new TableFootTag());
            set => _foot = value;
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

            foreach (var cell in Foot.Cells)
            {
                output.AppendFormat("<td>{0}</td>", cell.Text);
                output.AppendLine();
            }

            output.AppendLine("</tr>");
            output.AppendLine("</tfoot>");

            output.AppendFormat("<{0}>", name);
            output.AppendLine();

            return output.ToString();
        }
    }
}
