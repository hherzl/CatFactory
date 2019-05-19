namespace CatFactory.ObjectRelationalMapping
{
    /// <summary>
    /// Represents an unique constraint
    /// </summary>
    public class Unique : Constraint
    {
        #region [ Constructors ]

        /// <summary>
        /// Initializes a new instance of <see cref="Unique"/> class
        /// </summary>
        public Unique()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="Unique"/> class
        /// </summary>
        /// <param name="constraintName">Constraint name</param>
        public Unique(string constraintName)
            : base(constraintName)
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="Unique"/> class
        /// </summary>
        /// <param name="constraintName">Constraint name</param>
        /// <param name="key">Key for constraint</param>
        public Unique(string constraintName, string[] key)
            : base(constraintName, key)
        {
        }

        #endregion
    }
}
