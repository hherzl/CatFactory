using System.Diagnostics;

namespace CatFactory.CodeFactory
{
    /// <summary>
    /// Provides the abstract model for a line of code
    /// </summary>
    [DebuggerDisplay("Content={Content}")]
    public class Line : ILine
    {
        /// <summary>
        /// Initializes a new instance of <see cref="Line"/>
        /// </summary>
        public Line()
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="Line"/> class with tabs and content
        /// </summary>
        /// <param name="tabs">Tabs</param>
        /// <param name="content">Content</param>
        /// <param name="args">An object array that contains zero or more objects to format</param>
        public Line(int tabs, string content, params string[] args)
        {
            Indent = tabs;
            Content = args == null || args.Length == 0 ? content : string.Format(content, args);
        }

        /// <summary>
        /// Initializes a new instance of <see cref="Line"/> class with content
        /// </summary>
        /// <param name="content">Content</param>
        /// <param name="args">An object array that contains zero or more objects to format</param>
        public Line(string content, params string[] args)
        {
            Content = content;
            Content = args == null || args.Length == 0 ? content : string.Format(content, args);
        }

        /// <summary>
        /// Gets the indentation
        /// </summary>
        public int Indent { get; protected set; }

        /// <summary>
        /// Gets the content
        /// </summary>
        public string Content { get; protected set; }

        /// <summary>
        /// Indicates if the line is null or empty
        /// </summary>
        public bool IsNullOrEmpty
            => string.IsNullOrEmpty(Content);

        /// <summary>
        /// Returns a string that represents the current object
        /// </summary>
        /// <returns>A <see cref="string"/> that represents the current object</returns>
        public override string ToString()
            => Content;
    }
}
