using System.Diagnostics;

namespace CatFactory.ObjectRelationalMapping.Programmability
{
    /// <summary>
    /// Represents the result set for readable object
    /// </summary>
    [DebuggerDisplay("Name={Name}, Type={Type}, Length={Length}, IsNullable={IsNullable}")]
    public class ResultSet
    {
        /// <summary>
        /// Initializes a new instance of <see cref="ResultSet"/> class
        /// </summary>
        public ResultSet()
        {
        }

        /// <summary>
        /// Gets or sets the name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the type
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the length
        /// </summary>
        public int Length { get; set; }

        /// <summary>
        /// Gets or sets the precision
        /// </summary>
        public short Prec { get; set; }

        /// <summary>
        /// Gets or sets the scale
        /// </summary>
        public short Scale { get; set; }

        /// <summary>
        /// Gets or sets if result set allows null value
        /// </summary>
        public bool Nullable { get; set; }

        /// <summary>
        /// Gets or sets collation for result name
        /// </summary>
        public string Collation { get; set; }
    }
}
