namespace CatFactory.Mapping
{
    /// <summary>
    /// Represents the model for table function
    /// </summary>
    public interface ITableFunction : IReadableObject
    {
        /// <summary>
        /// Gets or sets the description
        /// </summary>
        string Description { get; set; }
    }
}
