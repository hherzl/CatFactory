namespace CatFactory
{
    /// <summary>
    /// Provides a model for naming convention
    /// </summary>
    public interface INamingConvention
    {
        /// <summary>
        /// Gets a valid name for programming language declaration
        /// </summary>
        /// <param name="name">Name</param>
        /// <returns>A <see cref="string"/> that represents a valid name in programming language declaration</returns>
        string ValidName(string name);
    }
}
