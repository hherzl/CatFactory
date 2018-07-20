namespace CatFactory.Mapping
{
    /// <summary>
    /// Represents the model for a database object
    /// </summary>
    public interface IDbObject
    {
        /// <summary>
        /// Gets or sets the schema
        /// </summary>
        string Schema { get; set; }

        /// <summary>
        /// Gets or sets the name
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Gets or sets the full name
        /// </summary>
        string FullName { get; }

        /// <summary>
        /// Gets or sets the type
        /// </summary>
        string Type { get; set; }
    }
}
