namespace CatFactory.ObjectRelationalMapping
{
    /// <summary>
    /// Represents the abstract model for column
    /// </summary>
    public interface IColumn
    {
        /// <summary>
        /// Gets or sets name
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Gets or sets type
        /// </summary>
        string Type { get; set; }

        /// <summary>
        /// Gets or sets length
        /// </summary>
        int Length { get; set; }

        /// <summary>
        /// Gets or sets precision
        /// </summary>
        short Prec { get; set; }

        /// <summary>
        /// Gets or sets scale
        /// </summary>
        short Scale { get; set; }

        /// <summary>
        /// Gets or sets if column allows null value
        /// </summary>
        bool Nullable { get; set; }

        /// <summary>
        /// Gets or sets collation for column
        /// </summary>
        string Collation { get; set; }

        /// <summary>
        /// Gets or sets the default value
        /// </summary>
        object DefaultValue { get; set; }

        /// <summary>
        /// Gets or sets description
        /// </summary>
        string Description { get; set; }
    }
}
