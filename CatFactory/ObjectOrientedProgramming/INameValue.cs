namespace CatFactory.ObjectOrientedProgramming
{
    /// <summary>
    /// Represents the model for name and value set
    /// </summary>
    public interface INameValue
    {
        /// <summary>
        /// Gets or sets the name
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Gets or sets the value
        /// </summary>
        string Value { get; set; }
    }
}
