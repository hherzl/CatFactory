using System.Diagnostics;

namespace CatFactory.Mapping
{
    /// <summary>
    /// Represents an extended property for a database object
    /// </summary>
    [DebuggerDisplay("Name={Name}, Value={Value}")]
    public class ExtendedProperty
    {
        /// <summary>
        /// Initializes a new instance of <see cref="ExtendedProperty"/> class
        /// </summary>
        public ExtendedProperty()
        {
        }

        /// <summary>
        /// Gets or sets the name for extended property
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the value for extended property
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets the level 0 type
        /// </summary>
        public string Level0Type { get; set; }

        /// <summary>
        /// Gets or sets the level 0 name
        /// </summary>
        public string Level0Name { get; set; }

        /// <summary>
        /// Gets or sets the level 1 type
        /// </summary>
        public string Level1Type { get; set; }

        /// <summary>
        /// Gets or sets the level 1 name
        /// </summary>
        public string Level1Name { get; set; }

        /// <summary>
        /// Gets or sets the level 2 type
        /// </summary>
        public string Level2Type { get; set; }

        /// <summary>
        /// Gets or sets the level 2 name
        /// </summary>
        public string Level2Name { get; set; }
    }
}
