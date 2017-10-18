using System.Diagnostics;

namespace CatFactory.CodeFactory
{
    [DebuggerDisplay("Content={Content}")]
    public class Line : ILine
    {
        public Line()
        {
        }

        public Line(int indent, string content, params string[] values)
        {
            Indent = indent;
            Content = values == null || values.Length == 0 ? content : string.Format(content, values);
        }

        public Line(string content, params string[] values)
        {
            Content = content;
            Content = values == null || values.Length == 0 ? content : string.Format(content, values);
        }

        public int Indent { get; protected set; }

        public string Content { get; protected set; }

        public bool IsNullOrEmpty
            => string.IsNullOrEmpty(Content);
    }
}
