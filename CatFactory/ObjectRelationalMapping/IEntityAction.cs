namespace CatFactory.ObjectRelationalMapping
{
    /// <summary>
    /// Represents an action for entity in object relational mapping context
    /// </summary>
    public interface IEntityAction
    {
        /// <summary>
        /// Gets the description for entity action
        /// </summary>
        string Description { get; }
    }
}
