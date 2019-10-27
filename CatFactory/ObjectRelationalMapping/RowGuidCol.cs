using System;
using System.Diagnostics;

namespace CatFactory.ObjectRelationalMapping
{
    /// <summary>
    /// Represents a row Guid column
    /// </summary>
    [DebuggerDisplay("Name={Name}")]
    [Obsolete("This is a model class for SQL Server")]
    public class RowGuidCol
    {
        #region [ Constructors ]

        /// <summary>
        /// Initializes a new instance of <see cref="RowGuidCol"/> class
        /// </summary>
        public RowGuidCol()
        {
        }

        #endregion

        #region [ Properties ]

        /// <summary>
        /// Gets or sets the column's name
        /// </summary>
        public string Name { get; set; }

        #endregion
    }
}
