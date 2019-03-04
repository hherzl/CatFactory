namespace CatFactory.CodeFactory
{
    /// <summary>
    /// Represents a line of to do for a programming language
    /// </summary>
    public class TodoLine : Line
    {
        /// <summary>
        /// Initializes a new instance of <see cref="TodoLine"/> class
        /// </summary>
        public TodoLine()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="TodoLine"/> class
        /// </summary>
        /// <param name="tabs">Tabs</param>
        /// <param name="content">Line content</param>
        /// <param name="values">An object array that contains zero or more objects to format</param>
        public TodoLine(int tabs, string content, params string[] values)
            : base(tabs, content, values)
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="TodoLine"/> class
        /// </summary>
        /// <param name="content">Line content</param>
        /// <param name="values">An object array that contains zero or more objects to format</param>
        public TodoLine(string content, params string[] values)
            : base(content, values)
        {
        }
    }
}
