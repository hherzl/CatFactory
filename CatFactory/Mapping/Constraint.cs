using System.Collections.Generic;
using System.Diagnostics;

namespace CatFactory.Mapping
{
    /// <summary>
    /// Represents a constraint for table
    /// </summary>
    [DebuggerDisplay("ConstraintName={ConstraintName}, Key={string.Join(\",\", Key)}")]
    public class Constraint : IConstraint
    {
        /// <summary>
        /// Initializes a new instance of <see cref="Constraint"/> class
        /// </summary>
        public Constraint()
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="Constraint"/> class
        /// </summary>
        /// <param name="key">Key for constraint</param>
        public Constraint(params string[] key)
        {
            Key.AddRange(key);
        }

        /// <summary>
        /// Gets or sets name for constraint
        /// </summary>
        public string ConstraintName { get; set; }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<string> m_key;

        /// <summary>
        /// Gets or sets key for constraint
        /// </summary>
        public List<string> Key
        {
            get
            {
                return m_key ?? (m_key = new List<string>());
            }
            set
            {
                m_key = value;
            }
        }
    }
}
