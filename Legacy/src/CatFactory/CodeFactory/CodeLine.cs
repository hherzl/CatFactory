namespace CatFactory.CodeFactory
{
    public class CodeLine : Line
    {
        public CodeLine()
            : base()
        {
        }

        public CodeLine(int indent, string content, params string[] values)
            : base(indent, content, values)
        {
        }

        public CodeLine(string content, params string[] values)
            : base(content, values)
        {
        }
    }
}
