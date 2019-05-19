namespace CatFactory.ObjectRelationalMapping
{
    /// <summary>
    /// Represents a primary key constraint
    /// </summary>
    public class PrimaryKey : Constraint
    {
        #region [ Constructors ]

        /// <summary>
        /// Initializes a new instance of <see cref="PrimaryKey"/> class
        /// </summary>
        public PrimaryKey()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="PrimaryKey"/> class
        /// </summary>
        /// <param name="constraintName">Constraint name</param>
        public PrimaryKey(string constraintName)
            : base(constraintName)
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="PrimaryKey"/> class
        /// </summary>
        /// <param name="constraintName">Constraint name</param>
        /// <param name="key">Key for constraint</param>
        public PrimaryKey(string constraintName, string[] key)
            : base(constraintName, key)
        {
        }

        #endregion
    }
}
