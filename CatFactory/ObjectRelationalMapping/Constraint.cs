using System.Collections.Generic;
using System.Diagnostics;

namespace CatFactory.ObjectRelationalMapping
{
    /// <summary>
    /// Represents a constraint for table
    /// </summary>
    [DebuggerDisplay("ConstraintName={ConstraintName}, Key={string.Join(\",\", Key)}")]
    public class Constraint : IConstraint
    {
        #region [ Fields ]

        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private List<string> m_key;

        #endregion

        #region [ Constructors ]

        /// <summary>
        /// Initializes a new instance of <see cref="Constraint"/> class
        /// </summary>
        public Constraint()
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="Constraint"/> class
        /// </summary>
        /// <param name="constraintName">Constraint name</param>
        public Constraint(string constraintName)
        {
            ConstraintName = constraintName;
        }

        /// <summary>
        /// Initializes a new instance of <see cref="Constraint"/> class
        /// </summary>
        /// <param name="constraintName">Constraint name</param>
        /// <param name="key">Key for constraint</param>
        public Constraint(string constraintName, string[] key)
        {
            ConstraintName = constraintName;
            Key.AddRange(key);
        }

        #endregion

        #region [ Properties ]

        /// <summary>
        /// Gets or sets name for constraint
        /// </summary>
        public string ConstraintName { get; set; }

        /// <summary>
        /// Gets or sets key for constraint
        /// </summary>
        public List<string> Key
        {
            get => m_key ?? (m_key = new List<string>());
            set => m_key = value;
        }

        #endregion
    }
}
