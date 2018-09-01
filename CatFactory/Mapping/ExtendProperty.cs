namespace CatFactory.Mapping
{
    /// <summary>
    /// Represents an extended property for a database object
    /// </summary>
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
    }
}
