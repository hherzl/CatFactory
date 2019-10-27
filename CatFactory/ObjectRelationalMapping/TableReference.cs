using System;

namespace CatFactory.ObjectRelationalMapping
{
    /// <summary>
    /// Represents a reference for user table
    /// </summary>
    [Obsolete("This is a model class for SQL Server")]
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
