using System.Collections.Generic;

namespace CatFactory.ObjectRelationalMapping
{
    /// <summary>
    /// Represents a constraint for table
    /// </summary>
    public interface IConstraint
    {
        /// <summary>
        /// Gets or sets name for constraint
        /// </summary>
        string ConstraintName { get; set; }

        /// <summary>
        /// Gets or sets key for constraint
        /// </summary>
        List<string> Key { get; set; }
    }
}
