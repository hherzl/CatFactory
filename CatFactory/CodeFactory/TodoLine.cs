namespace CatFactory.CodeFactory
{
    /// <summary>
    /// 
    /// </summary>
    public class TodoLine : Line
    {
        /// <summary>
        /// 
        /// </summary>
        public TodoLine()
            : base()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="indent"></param>
        /// <param name="content"></param>
        /// <param name="values"></param>
        public TodoLine(int indent, string content, params string[] values)
            : base(indent, content, values)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="content"></param>
        /// <param name="values"></param>
        public TodoLine(string content, params string[] values)
            : base(content, values)
        {
        }
    }
}
