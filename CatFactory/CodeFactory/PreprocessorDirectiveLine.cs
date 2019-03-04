namespace CatFactory.CodeFactory
{
    /// <summary>
    /// Represents a line of preprocessor directive for a programming language
    /// </summary>
    public class PreprocessorDirectiveLine : Line
    {
        /// <summary>
        /// Initializes a new instance of <see cref="PreprocessorDirectiveLine"/> class
        /// </summary>
        public PreprocessorDirectiveLine()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="PreprocessorDirectiveLine"/> class
        /// </summary>
        /// <param name="tabs">Tabs</param>
        /// <param name="content">Line content</param>
        /// <param name="values">An object array that contains zero or more objects to format</param>
        public PreprocessorDirectiveLine(int tabs, string content, params string[] values)
            : base(tabs, content, values)
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="PreprocessorDirectiveLine"/> class
        /// </summary>
        /// <param name="content">Line content</param>
        /// <param name="values">An object array that contains zero or more objects to format</param>
        public PreprocessorDirectiveLine(string content, params string[] values)
            : base(content, values)
        {
        }
    }
}
