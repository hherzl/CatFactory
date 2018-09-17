namespace CatFactory.CodeFactory
{
    /// <summary>
    /// 
    /// </summary>
    public class PreprocessorDirectiveLine : Line
    {
        /// <summary>
        /// 
        /// </summary>
        public PreprocessorDirectiveLine()
            : base()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="indent"></param>
        /// <param name="content"></param>
        /// <param name="values"></param>
        public PreprocessorDirectiveLine(int indent, string content, params string[] values)
            : base(indent, content, values)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="content"></param>
        /// <param name="values"></param>
        public PreprocessorDirectiveLine(string content, params string[] values)
            : base(content, values)
        {
        }
    }
}
