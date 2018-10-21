using CatFactory.Diagnostics;

namespace CatFactory.ObjectRelationalMapping.Validation
{
    /// <summary>
    /// Represents a validation result for database's structure
    /// </summary>
    public interface IDatabaseValidator
    {
        /// <summary>
        /// Gets a validation result that contains all validation messages from validate action
        /// </summary>
        /// <param name="database">A database instance</param>
        /// <returns>A validation result that contains all validation messages (Log level and message) from validate action</returns>
        ValidationResult Validate(Database database);
    }
}
