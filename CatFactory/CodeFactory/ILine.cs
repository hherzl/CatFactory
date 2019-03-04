namespace CatFactory.CodeFactory
{
    /// <summary>
    /// Provides the abstract model for a line of code
    /// </summary>
    public interface ILine
    {
        /// <summary>
        /// Gets the indentation
        /// </summary>
        int Indent { get; }

        /// <summary>
        /// Gets the content
        /// </summary>
        string Content { get; }

        /// <summary>
        /// Indicates if the line is null or empty
        /// </summary>
        bool IsNullOrEmpty { get; }
    }
}
