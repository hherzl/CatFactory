namespace CatFactory
{
    /// <summary>
    /// Allows to singularize or pluralize words
    /// </summary>
    public class NamingService : INamingService
    {
        #region [ Constructors ]

        /// <summary>
        /// Initializes a new instance of <see cref="NamingService"/> class
        /// </summary>
        public NamingService()
        {
        }

        #endregion

        #region [ Members of INamingService ]

        /// <summary>
        /// Singularizes an input string
        /// </summary>
        /// <param name="value">A word that represents an object</param>
        /// <returns>A <see cref="string"/> that represents the singular form for input word</returns>
        public virtual string Singularize(string value)
        {
            // todo: improve the way to singularize a name

            if (value.EndsWith("ies"))
                return string.Format("{0}y", value.Substring(0, value.Length - 3));
            else if (value.EndsWith("sses"))
                return string.Format("{0}", value.Substring(0, value.Length - 2));
            else if (value.EndsWith("uses"))
                return string.Format("{0}", value.Substring(0, value.Length - 2));
            else if (value.EndsWith("es"))
                return string.Format("{0}", value.Substring(0, value.Length - 1));
            else if (value.EndsWith("tus"))
                return value;
            else if (value.EndsWith("s"))
                return string.Format("{0}", value.Substring(0, value.Length - 1));
            else
                return value;
        }

        /// <summary>
        /// Pluralizes an input string
        /// </summary>
        /// <param name="value">A word that represents an object</param>
        /// <returns>A <see cref="string"/> that represents the plural form for input word</returns>
        public virtual string Pluralize(string value)
        {
            // todo: improve the way to pluralize a name

            if (value.EndsWith("ss"))
                return string.Format("{0}es", value);
            else if (value.EndsWith("y"))
                return string.Format("{0}ies", value.Substring(0, value.Length - 1));
            else if (value.EndsWith("tuses"))
                return value;
            else if (value.EndsWith("tus"))
                return string.Format("{0}es", value);
            else if (value.EndsWith("s"))
                return value;
            else
                return string.Format("{0}s", value);
        }

        #endregion
    }
}
