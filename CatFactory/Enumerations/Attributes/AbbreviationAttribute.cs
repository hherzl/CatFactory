namespace CatFactory.Enumerations.Attributes
{
    /// <inheritdoc />
    /// <summary>
    ///     A Single referred short abbreviation string is convenience.
    ///     Preferred short abbreviation enum types matched to string values often don't match due to human errors.
    /// </summary>
    /// <TODO>
    ///     Either convert to a CSV String, or List, or throw an error when comma, semi-colon or other standard separator is
    ///     discovered.
    /// </TODO>
    public sealed class AbbreviationAttribute : System.Attribute
    {
        #region Public Constructors

        /// <inheritdoc />
        /// <summary>
        ///     Constructor
        /// </summary>
        /// <param name="abbreviation"></param>
        public AbbreviationAttribute(System.String abbreviation) => this.Abbreviation = abbreviation;

        #endregion Public Constructors

        #region Public Properties

        /// <summary>
        /// </summary>
        public System.String Abbreviation { get; }

        #endregion Public Properties

        #region Public Methods

        /// <summary>
        ///     Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override System.String ToString() => this.Abbreviation;

        #endregion Public Methods
    }
}
