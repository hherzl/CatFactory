namespace CatFactory.ObjectRelationalMapping.Actions
{
    /// <summary>
    /// Represents a read by key operation for entity
    /// </summary>
    public class ReadByKeyAction : IEntityAction
    {
        /// <summary>
        /// Gets the description for entity action
        /// </summary>
        public string Description
            => "Allows to read an entity from storage by key, in SQL this action is performed by SELECT statement and WHERE clause.";
    }
}
