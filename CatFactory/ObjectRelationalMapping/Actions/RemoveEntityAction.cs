namespace CatFactory.ObjectRelationalMapping.Actions
{
    /// <summary>
    /// Represents a remove operation for entity
    /// </summary>
    public class RemoveEntityAction : IEntityAction
    {
        #region [ Constructors ]

        /// <summary>
        /// 
        /// </summary>
        public RemoveEntityAction()
        {
        }

        #endregion

        #region [ Members of IEntityAction ]

        /// <summary>
        /// Gets the description for entity action
        /// </summary>
        public string Description
            => "Allows to delete an existing entity in storage, in SQL this action is performed by DELETE statement.";

        #endregion
    }
}
