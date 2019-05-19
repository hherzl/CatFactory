namespace CatFactory.ObjectRelationalMapping
{
    /// <summary>
    /// Represents a foreign key constraint
    /// </summary>
    public class ForeignKey : Constraint
    {
        #region [ Constructors ]

        /// <summary>
        /// Initializes a new instance of <see cref="ForeignKey"/> class
        /// </summary>
        public ForeignKey()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="ForeignKey"/> class
        /// </summary>
        /// <param name="constraintName">Constraint name</param>
        public ForeignKey(string constraintName)
            : base(constraintName)
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="ForeignKey"/> class
        /// </summary>
        /// <param name="constraintName">Constraint name</param>
        /// <param name="key">Key for constraint</param>
        public ForeignKey(string constraintName, string[] key)
            : base(constraintName, key)
        {
        }

        #endregion

        #region [ Properties ]

        /// <summary>
        /// Gets or sets the reference table
        /// </summary>
        public string References { get; set; }

        /// <summary>
        /// Gets or sets the name for child table
        /// </summary>
        public string Child { get; set; }

        #endregion
    }
}
