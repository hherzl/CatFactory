namespace CatFactory.ObjectRelationalMapping
{
    /// <summary>
    /// Represents a reference for user table
    /// </summary>
    public class TableReference
    {
        #region [ Constructors ]

        /// <summary>
        /// Initializes a new instance of <see cref="TableReference"/> class
        /// </summary>
        public TableReference()
        {
        }

        #endregion

        #region [ Properties ]

        /// <summary>
        /// Gets or sets the reference description
        /// </summary>
        public string ReferenceDescription { get; set; }

        #endregion
    }
}
