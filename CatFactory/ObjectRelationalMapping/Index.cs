using System.Diagnostics;

namespace CatFactory.ObjectRelationalMapping
{
    /// <summary>
    /// Represents an index for a table or view
    /// </summary>
    [DebuggerDisplay("IndexName={IndexName}, IndexDescription={IndexDescription}, IndexKeys={IndexKeys}")]
    public class Index
    {
        #region [ Constructors ]

        /// <summary>
        /// Initializes a new instance of <see cref="Index"/> class
        /// </summary>
        public Index()
        {
        }

        #endregion

        #region [ Properties ]

        /// <summary>
        /// Gets or sets the index name
        /// </summary>
        public string IndexName { get; set; }

        /// <summary>
        /// Gets or sets the index description
        /// </summary>
        public string IndexDescription { get; set; }

        /// <summary>
        /// Gets or sets the index keys
        /// </summary>
        public string IndexKeys { get; set; }

        #endregion
    }
}
