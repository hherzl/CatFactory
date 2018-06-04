using System.Diagnostics;

namespace CatFactory.Mapping
{
    /// <summary>
    /// Represents a row Guid column
    /// </summary>
    [DebuggerDisplay("Name={Name}")]
    public class RowGuidCol
    {
        /// <summary>
        /// Initializes a new instance of <see cref="CatFactory.Mapping.RowGuidCol"/> class
        /// </summary>
        public RowGuidCol()
        {
        }

        /// <summary>
        /// Gets or sets the column's name
        /// </summary>
        public string Name { get; set; }
    }
}
