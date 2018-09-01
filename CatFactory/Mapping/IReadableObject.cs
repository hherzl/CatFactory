using System;
using System.Collections.Generic;

namespace CatFactory.Mapping
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
        /// Gets a column by name
        /// </summary>
        /// <param name="name">Name for column</param>
        /// <returns>A column as selection result</returns>
        [Obsolete("Use Indexer")]
        Column GetColumn(string name);
    }
}
