namespace CatFactory.ObjectRelationalMapping.Actions
{
    /// <summary>
    /// Represents an addition operation for entity
    /// </summary>
    public class AddEntityAction : IEntityAction
    {
        /// <summary>
        /// Gets the description for entity action
        /// </summary>
        public string Description
            => "Allows to add a new entity in storage, in SQL this action is performed by INSERT INTO statement.";
    }
}
