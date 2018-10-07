using System.Diagnostics;

namespace CatFactory.Mapping
{
    /// <summary>
    /// Represents the first result set for object (database object)
    /// </summary>
    [DebuggerDisplay("Name={Name}, SystemTypeName={SystemTypeName}")]
    public class FirstResultSetForObject
    {
        /// <summary>
        /// Gets or sets the column ordinal
        /// </summary>
        public int ColumnOrdinal { get; set; }

        /// <summary>
        /// Gets or sets the name for result
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets if column is nullable
        /// </summary>
        public bool IsNullable { get; set; }

        /// <summary>
        /// Gets or sets the system type (database type) name
        /// </summary>
        public string SystemTypeName { get; set; }
    }
}
