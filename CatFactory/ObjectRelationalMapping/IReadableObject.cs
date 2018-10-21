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
    }
}
