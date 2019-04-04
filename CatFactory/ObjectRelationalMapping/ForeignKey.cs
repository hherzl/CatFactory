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
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="ForeignKey"/> class
        /// </summary>
        /// <param name="key">Key for constraint</param>
        public ForeignKey(params string[] key)
            : base(key)
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
