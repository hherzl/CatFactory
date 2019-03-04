using CatFactory.Diagnostics;

namespace CatFactory.CodeFactory.Scaffolding
{
    /// <summary>
    /// Provides a model for project settings
    /// </summary>
    public interface IProjectSettings
    {
        /// <summary>
        /// Validates the settings
        /// </summary>
        /// <returns>A <see cref="ValidationResult"/> that contains information about validation</returns>
        ValidationResult Validate();
    }
}
