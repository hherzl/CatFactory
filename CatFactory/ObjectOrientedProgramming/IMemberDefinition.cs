namespace CatFactory.ObjectOrientedProgramming
{
    /// <summary>
    /// Represents the model for Member definition
    /// </summary>
    public interface IMemberDefinition
    {
        /// <summary>
        /// Gets or sets the access modifier
        /// </summary>
        AccessModifier AccessModifier { get; set; }

        /// <summary>
        /// Gets or sets the type
        /// </summary>
        string Type { get; set; }

        /// <summary>
        /// Gets or sets the name
        /// </summary>
        string Name { get; set; }
    }
}
