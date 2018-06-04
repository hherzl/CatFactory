namespace CatFactory.Mapping
{
    /// <summary>
    /// Represents the model for user table
    /// </summary>
    public interface IView : IReadableObject
    {
        /// <summary>
        /// Gets or sets the description
        /// </summary>
        string Description { get; set; }
    }
}
