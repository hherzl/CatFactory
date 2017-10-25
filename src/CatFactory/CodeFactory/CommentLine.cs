namespace CatFactory.CodeFactory
{
    public class CommentLine : Line
    {
        public CommentLine()
            : base()
        {
        }

        public CommentLine(int indent, string content, params string[] values)
            : base(indent, content, values)
        {
        }

        public CommentLine(string content, params string[] values)
            : base(content, values)
        {
        }
    }
}
