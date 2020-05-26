namespace CatFactory.ObjectRelationalMapping
{
    /// <summary>
    /// Represents a default constraint
    /// </summary>
    public class Default : Constraint
    {
        #region [ Constructors ]

        /// <summary>
        /// Initializes a new instance of <see cref="Default"/> class
        /// </summary>
        public Default()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="Default"/> class
        /// </summary>
        /// <param name="constraintName">Constraint name</param>
        public Default(string constraintName)
            : base(constraintName)
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="Default"/> class
        /// </summary>
        /// <param name="constraintName">Constraint name</param>
        /// <param name="key">Key for constraint</param>
        public Default(string constraintName, string key)
            : base(constraintName, new string[] { key })
        {
        }

        #endregion

        #region [ Properties ]

        /// <summary>
        /// Gets or sets the value for default constraint
        /// </summary>
        public string Value { get; set; }

        #endregion
    }
}
