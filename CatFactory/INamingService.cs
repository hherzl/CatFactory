namespace CatFactory
{
    /// <summary>
    /// Provides the model for naming feature
    /// </summary>
    public interface INamingService
    {
        /// <summary>
        /// Singularizes an input string
        /// </summary>
        /// <param name="value">A word that represents an object</param>
        /// <returns>A <see cref="string"/> that represents the singular form for input word</returns>
        string Singularize(string value);

        /// <summary>
        /// Pluralizes an input string
        /// </summary>
        /// <param name="value">A word that represents an object</param>
        /// <returns>A <see cref="string"/> that represents the plural form for input word</returns>
        string Pluralize(string value);
    }
}
