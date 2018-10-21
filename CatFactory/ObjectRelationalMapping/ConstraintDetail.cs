using System.Diagnostics;

namespace CatFactory.ObjectRelationalMapping
{
    /// <summary>
    /// Represents details for constraint
    /// </summary>
    [DebuggerDisplay("ConstraintType={ConstraintType}, ConstraintName={ConstraintName}, ConstraintKeys={ConstraintKeys}")]
    public class ConstraintDetail
    {
        /// <summary>
        /// Initializes a new instance of <see cref="ConstraintDetail"/> class
        /// </summary>
        public ConstraintDetail()
        {
        }

        /// <summary>
        /// Gets or sets the constraint's type
        /// </summary>
        public string ConstraintType { get; set; }

        /// <summary>
        /// Gets or sets the constraint's name
        /// </summary>
        public string ConstraintName { get; set; }

        /// <summary>
        /// Gets or sets the constraint's delete action
        /// </summary>
        public string DeleteAction { get; set; }

        /// <summary>
        /// Gets or sets the constraint's update action
        /// </summary>
        public string UpdateAction { get; set; }

        /// <summary>
        /// Gets or sets the constraint's status enabled
        /// </summary>
        public string StatusEnabled { get; set; }

        /// <summary>
        /// Gets or sets the constraint's status for replication
        /// </summary>
        public string StatusForReplication { get; set; }

        /// <summary>
        /// Gets or sets the constraint's keys
        /// </summary>
        public string ConstraintKeys { get; set; }
    }
}
