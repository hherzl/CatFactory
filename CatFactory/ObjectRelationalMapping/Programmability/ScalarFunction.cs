using System.Collections.Generic;
using System.Diagnostics;

namespace CatFactory.ObjectRelationalMapping.Programmability
{
    /// <summary>
    /// Represents a scalar function
    /// </summary>
    [DebuggerDisplay("FullName={FullName}, Parameters={Parameters.Count}")]
    public class ScalarFunction : DbObject, IScalarFunction
    {
        #region [ Fields ]

        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private List<Parameter> m_parameters;

        #endregion

        #region [ Constructors ]

        /// <summary>
        /// Initializes a new instance of <see cref="ScalarFunction"/> class
        /// </summary>
        public ScalarFunction()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="ScalarFunction"/> class
        /// </summary>
        /// <param name="schema">Schema</param>
        /// <param name="name">Name</param>
        public ScalarFunction(string schema, string name)
            : base(schema, name)
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="TableFunction"/> class
        /// </summary>
        /// <param name="dataSource">Data source</param>
        /// <param name="catalog">Catalog</param>
        /// <param name="schema">Schema</param>
        /// <param name="name">Name</param>
        public ScalarFunction(string dataSource, string catalog, string schema, string name)
            : base(dataSource, catalog, schema, name)
        {
        }

        #endregion

        #region [ Properties ]

        /// <summary>
        /// Gets or sets the description
        /// </summary>
        public string Description { get; set; }

        #endregion

        #region [ Members of IScalarFunction ]

        /// <summary>
        /// Gets or sets the parameters list
        /// </summary>
        public List<Parameter> Parameters
        {
            get => m_parameters ??= new List<Parameter>();
            set => m_parameters = value;
        }

        #endregion
    }
}
