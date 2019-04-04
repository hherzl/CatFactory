namespace CatFactory.ObjectRelationalMapping.Actions
{
    /// <summary>
    /// Represents a read all operation for entities
    /// </summary>
    public class ReadAllAction : IEntityAction
    {
        #region [ Constructors ]

        /// <summary>
        /// 
        /// </summary>
        public ReadAllAction()
        {
        }

        #endregion

        #region [ Members of IEntityAction ]

        /// <summary>
        /// Gets the description for entity action
        /// </summary>
        public string Description
            => "Allows to read a result set of entities from storage, in SQL this action is performed by SELECT statement.";

        #endregion
    }
}
