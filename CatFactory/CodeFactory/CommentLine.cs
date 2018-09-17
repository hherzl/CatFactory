namespace CatFactory.CodeFactory
{
    /// <summary>
    /// 
    /// </summary>
    public class CommentLine : Line
    {
        /// <summary>
        /// 
        /// </summary>
        public CommentLine()
            : base()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="indent"></param>
        /// <param name="content"></param>
        /// <param name="values"></param>
        public CommentLine(int indent, string content, params string[] values)
            : base(indent, content, values)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="content"></param>
        /// <param name="values"></param>
        public CommentLine(string content, params string[] values)
            : base(content, values)
        {
        }
    }
}
