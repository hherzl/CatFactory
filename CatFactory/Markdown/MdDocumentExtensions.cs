using System.Linq;
using CatFactory.CodeFactory;

namespace CatFactory.Markdown
{
    /// <summary>
    /// 
    /// </summary>
    public static class MdDocumentExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="document"></param>
        /// <param name="highlighting"></param>
        /// <param name="lines"></param>
        public static void CodeBlock(this MdDocument document, string highlighting, params string[] lines)
        {
            document.Lines.Add(new Line("```{0}", highlighting));

            foreach (var line in lines)
            {
                document.Lines.Add(new Line(line));
            }

            document.Lines.Add(new Line("```"));
            document.Lines.Add(new Line());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="document"></param>
        /// <param name="value"></param>
        /// <param name="args"></param>
        public static void H1(this MdDocument document, string value, params string[] args)
        {
            document.Lines.Add(new Line(Md.H1(value)));
            document.Lines.Add(new Line());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="document"></param>
        /// <param name="value"></param>
        /// <param name="args"></param>
        public static void H2(this MdDocument document, string value, params string[] args)
        {
            document.Lines.Add(new Line(Md.H2(value)));
            document.Lines.Add(new Line());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="document"></param>
        /// <param name="value"></param>
        /// <param name="args"></param>
        public static void H3(this MdDocument document, string value, params string[] args)
        {
            document.Lines.Add(new Line(Md.H3(value)));
            document.Lines.Add(new Line());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="document"></param>
        /// <param name="value"></param>
        /// <param name="args"></param>
        public static void H4(this MdDocument document, string value, params string[] args)
        {
            document.Lines.Add(new Line(Md.H4(value)));
            document.Lines.Add(new Line());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="document"></param>
        /// <param name="value"></param>
        /// <param name="args"></param>
        public static void H5(this MdDocument document, string value, params string[] args)
        {
            document.Lines.Add(new Line(Md.H5(value)));
            document.Lines.Add(new Line());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="document"></param>
        /// <param name="value"></param>
        /// <param name="args"></param>
        public static void H6(this MdDocument document, string value, params string[] args)
        {
            document.Lines.Add(new Line(Md.H6(value)));
            document.Lines.Add(new Line());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="document"></param>
        /// <param name="args"></param>
        public static void OrderedList(this MdDocument document, params string[] args)
        {
            for (var i = 0; i < args.Length; i++)
            {
                var item = args[i];

                document.Lines.Add(new Line(Md.Item(string.Format("{0}.", i + 1), item)));
            }

            document.Lines.Add(new Line());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="document"></param>
        /// <param name="args"></param>
        public static void UnorderedList(this MdDocument document, params string[] args)
        {
            for (var i = 0; i < args.Length; i++)
            {
                var item = args[i];

                document.Lines.Add(new Line(Md.Item("+", item)));
            }

            document.Lines.Add(new Line());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="document"></param>
        /// <param name="value"></param>
        /// <param name="args"></param>
        public static void WriteLine(this MdDocument document, string value, params string[] args)
        {
            document.Lines.Add(new Line(value, args));
            document.Lines.Add(new Line());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="document"></param>
        /// <param name="table"></param>
        public static void Write(this MdDocument document, MdTable table)
        {
            document.Lines.Add(new Line("|{0}|", string.Join("|", table.Header.Cells.Select(item => item))));
            document.Lines.Add(new Line("|{0}|", string.Join("|", table.Header.Cells.Select(item => string.Join("", Enumerable.Repeat("-", item.Length))))));

            foreach (var row in table.Rows)
            {
                document.Lines.Add(new Line("|{0}|", string.Join("|", row.Cells.Select(item => item))));
            }

            document.Lines.Add(new Line());
        }
    }
}
