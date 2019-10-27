using System.Collections.Generic;

namespace CatFactory.ObjectRelationalMapping
{
    /// <summary>
    /// Represents a model for a readable object
    /// </summary>
    public interface IReadableObject : IDbObject
    {
        /// <summary>
        /// Gets or sets the columns list
        /// </summary>
        List<Column> Columns { get; set; }

        /// <summary>
        /// Gets or sets a column by index
        /// </summary>
        /// <param name="index">Column index</param>
        /// <returns>A <see cref="IColumn"/> from object</returns>
        Column this[int index] { get; set; }

        /// <summary>
        /// Gets or sets a column by name
        /// </summary>
        /// <param name="name">Column name</param>
        /// <returns>A <see cref="Column"/> from current table</returns>
        Column this[string name] { get; set; }
    }
}
