namespace CatFactory.CodeFactory
{
    /// <summary>
    /// 
    /// </summary>
    public class CodeLine : Line
    {
        /// <summary>
        /// 
        /// </summary>
        public CodeLine()
            : base()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="indent"></param>
        /// <param name="content"></param>
        /// <param name="values"></param>
        public CodeLine(int indent, string content, params string[] values)
            : base(indent, content, values)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="content"></param>
        /// <param name="values"></param>
        public CodeLine(string content, params string[] values)
            : base(content, values)
        {
        }
    }
}
