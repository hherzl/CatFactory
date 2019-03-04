namespace CatFactory.CodeFactory
{
    /// <summary>
    /// Represents a value for object declaration
    /// </summary>
    public interface IObjectValue : IValue
    {
        /// <summary>
        /// Gets or sets the value
        /// </summary>
        object Value { get; set; }
    }
}
