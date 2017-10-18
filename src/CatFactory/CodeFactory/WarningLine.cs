namespace CatFactory.CodeFactory
{
    public class WarningLine : Line
    {
        public WarningLine()
            : base()
        {
        }

        public WarningLine(int indent, string content, params string[] values)
            : base(indent, content, values)
        {
        }

        public WarningLine(string content, params string[] values)
            : base(content, values)
        {
        }

        public override string ToString()
            => Content;
    }
}
