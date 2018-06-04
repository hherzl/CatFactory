using System.Collections.Generic;
using CatFactory.Diagnostics;

namespace CatFactory.Mapping
{
    /// <summary>
    /// Represents a validator for database's structure
    /// </summary>
    public interface IDatabaseValidator
    {
        /// <summary>
        /// Gets a sequence that contains all validation messages from validate feature
        /// </summary>
        /// <param name="database">A database instance</param>
        /// <returns></returns>
        IEnumerable<ValidationMessage> Validate(Database database);
    }
}
