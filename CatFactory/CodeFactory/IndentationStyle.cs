namespace CatFactory.CodeFactory
{
    /// <summary>
    /// Represents the indentation style for programming language
    /// </summary>
    /// <remarks>This enum is based on https://en.wikipedia.org/wiki/Indentation_style</remarks>
    public enum IndentationStyle : short
    {
        /// <summary>
        /// Example:
        /// while (x == y)
        /// {
        ///     something();
        ///     somethingelse();
        /// }
        /// </summary>
        Allman,

        /// <summary>
        /// Example:
        /// while (x == y) {
        ///     something();
        ///     somethingElse();
        /// }
        /// </summary>
        KR
    }
}
