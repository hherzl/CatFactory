using System.Diagnostics;

namespace CatFactory.Mapping
{
    /// <summary>
    /// Represents an index for a table
    /// </summary>
    [DebuggerDisplay("IndexName={IndexName}, IndexDescription={IndexDescription}, IndexKeys={IndexKeys}")]
    public class Index
    {
        /// <summary>
        /// Initializes a new instance of <see cref="Index"/> class
        /// </summary>
        public Index()
        {
        }

        /// <summary>
        /// Gets or sets the index's name
        /// </summary>
        public string IndexName { get; set; }

        /// <summary>
        /// Gets or sets the index's description
        /// </summary>
        public string IndexDescription { get; set; }

        /// <summary>
        /// Gets or sets the index's keys
        /// </summary>
        public string IndexKeys { get; set; }
    }
}
