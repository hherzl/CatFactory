using System.Data;
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
        /// Gets or sets the parameter name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the parameter type
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the parameter length
        /// </summary>
        public short Length { get; set; }

        /// <summary>
        /// Gets or sets the parameter precision
        /// </summary>
        public int Prec { get; set; }

        /// <summary>
        /// Gets or sets the parameter scale
        /// </summary>
        public int Scale { get; set; }

        /// <summary>
        /// Gets or sets the parameter order
        /// </summary>
        public int Order { get; set; }

        /// <summary>
        /// Gets or sets the parameter collation
        /// </summary>
        public string Collation { get; set; }

        /// <summary>
        /// Gets or sets the parameter direction
        /// </summary>
        public ParameterDirection Direction { get; set; }

        /// <summary>
        /// Gets or sets the parameter data type
        /// </summary>
        public DbType DbType { get; set; }

        #endregion
    }
}
