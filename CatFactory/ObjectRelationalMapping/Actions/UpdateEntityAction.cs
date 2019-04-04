namespace CatFactory.ObjectRelationalMapping.Actions
{
    /// <summary>
    /// Represents an update operation for entity
    /// </summary>
    public class UpdateEntityAction : IEntityAction
    {
        #region [ Constructors ]

        /// <summary>
        /// 
        /// </summary>
        public UpdateEntityAction()
        {
        }

        #endregion

        #region [ Members of IEntityAction ]

        /// <summary>
        /// Gets the description for entity action
        /// </summary>
        public string Description
            => "Allows to update an existing entity in storage, in SQL this action is performed by UPDATE statement.";

        #endregion
    }
}
