namespace CatFactory.CodeFactory
{
    public class TodoLine : Line
    {
        public TodoLine()
            : base()
        {
        }

        public TodoLine(int indent, string content, params string[] values)
            : base(indent, content, values)
        {
        }

        public TodoLine(string content, params string[] values)
            : base(content, values)
        {
        }
    }
}
