namespace CatFactory.CodeFactory
{
    public class PreprocessorDirectiveLine : Line
    {
        public PreprocessorDirectiveLine()
            : base()
        {
        }

        public PreprocessorDirectiveLine(int indent, string content, params string[] values)
            : base(indent, content, values)
        {
        }

        public PreprocessorDirectiveLine(string content, params string[] values)
            : base(content, values)
        {
        }
    }
}
