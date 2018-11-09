namespace CatFactory.CodeFactory
{
    /// <summary>
    /// 
    /// </summary>
    public class ReturnLine : Line
    {
        /// <summary>
        /// 
        /// </summary>
        public ReturnLine()
            : base()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="indent"></param>
        /// <param name="content"></param>
        /// <param name="values"></param>
        public ReturnLine(int indent, string content, params string[] values)
            : base(indent, content, values)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="content"></param>
        /// <param name="values"></param>
        public ReturnLine(string content, params string[] values)
            : base(content, values)
        {
        }
    }
}
