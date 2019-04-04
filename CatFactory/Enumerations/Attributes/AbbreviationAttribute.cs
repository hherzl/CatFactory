using System;

namespace CatFactory.Enumerations.Attributes
{
    /// <inheritdoc />
    /// <summary>
    /// A Single referred short abbreviation string is convenience.
    /// Preferred short abbreviation enum types matched to string values often don't match due to human errors.
    /// </summary>
    /// <TODO>
    /// Either convert to a CSV String, or List, or throw an error when comma, semi-colon or other standard separator is
    /// discovered.
    /// </TODO>
    public sealed class AbbreviationAttribute : Attribute
    {
        #region Constructors

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of <see cref="AbbreviationAttribute"/> class
        /// </summary>
        /// <param name="abbreviation"></param>
        public AbbreviationAttribute(string abbreviation)
            => Abbreviation = abbreviation;

        #endregion

        #region Properties

        /// <summary>
        /// Gets the abbreviation
        /// </summary>
        public string Abbreviation { get; }

        #endregion

        #region Methods

        /// <summary>
        /// Gets the string presentation of the object
        /// </summary>
        /// <returns><see cref="string"/> presentation of the object</returns>
        public override string ToString()
            => Abbreviation;

        #endregion
    }
}
