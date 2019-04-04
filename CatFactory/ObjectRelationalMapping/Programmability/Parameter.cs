using System.Diagnostics;

namespace CatFactory.ObjectRelationalMapping.Programmability
{
    /// <summary>
    /// Represents a parameter for SQL
    /// </summary>
    [DebuggerDisplay("Name={Name}, Type={Type}, Length={Length}")]
    public class Parameter
    {
        #region [ Constructors ]

        /// <summary>
        /// Initializes a new instance of <see cref="Parameter"/> class
        /// </summary>
        public Parameter()
        {
        }

        #endregion

        #region [ Properties ]

        /// <summary>
        /// Gets or sets the parameter's name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the parameter's type
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the parameter's length
        /// </summary>
        public short Length { get; set; }

        /// <summary>
        /// Gets or sets the parameter's precision
        /// </summary>
        public int Prec { get; set; }

        /// <summary>
        /// Gets or sets the parameter's scale
        /// </summary>
        public int Scale { get; set; }

        /// <summary>
        /// Gets or sets the parameter's parameter order
        /// </summary>
        public int ParamOrder { get; set; }

        /// <summary>
        /// Gets or sets the parameter's collation
        /// </summary>
        public string Collation { get; set; }

        #endregion
    }
}
