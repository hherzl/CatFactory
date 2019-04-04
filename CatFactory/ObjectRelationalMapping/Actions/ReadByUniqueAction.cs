namespace CatFactory.ObjectRelationalMapping.Actions
{
    /// <summary>
    /// Represents a read by unique operation for entity
    /// </summary>
    public class ReadByUniqueAction : IEntityAction
    {
        #region [ Constructors ]

        /// <summary>
        /// 
        /// </summary>
        public ReadByUniqueAction()
        {
        }

        #endregion

        #region [ Members of IEntityAction ]

        /// <summary>
        /// Gets the description for entity action
        /// </summary>
        public string Description
            => "Allows to read an entity from storage by unique, in SQL this action is performed by SELECT statement and WHERE clause.";

        #endregion
    }
}
