namespace CatFactory.ObjectRelationalMapping
{
    /// <summary>
    /// Represents a check constraint
    /// </summary>
    public class Check : Constraint
    {
        #region [ Constructors ]

        /// <summary>
        /// Initializes a new instance of <see cref="Check"/> class
        /// </summary>
        public Check()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="Check"/> class
        /// </summary>
        /// <param name="constraintName">Constraint name</param>
        public Check(string constraintName)
            : base(constraintName)
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="Check"/> class
        /// </summary>
        /// <param name="constraintName">Constraint name</param>
        /// <param name="key">Key for constraint</param>
        public Check(string constraintName, string[] key)
            : base(constraintName, key)
        {
        }

        #endregion
    }
}
