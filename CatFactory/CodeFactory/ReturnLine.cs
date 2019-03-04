namespace CatFactory.CodeFactory
{
    /// <summary>
    /// Represents a line of return for a programming language
    /// </summary>
    public class ReturnLine : Line
    {
        /// <summary>
        /// Initializes a new instance of <see cref="ReturnLine"/> class
        /// </summary>
        public ReturnLine()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="ReturnLine"/> class
        /// </summary>
        /// <param name="tabs">Tabs</param>
        /// <param name="content">Line content</param>
        /// <param name="values">An object array that contains zero or more objects to format</param>
        public ReturnLine(int tabs, string content, params string[] values)
            : base(tabs, content, values)
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="ReturnLine"/> class
        /// </summary>
        /// <param name="content">Line content</param>
        /// <param name="values">An object array that contains zero or more objects to format</param>
        public ReturnLine(string content, params string[] values)
            : base(content, values)
        {
        }
    }
}
