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
        /// <summary>
        /// Initializes a new instance of <see cref="ScalarFunction"/> class
        /// </summary>
        public ScalarFunction()
        {
        }

        /// <summary>
        /// Gets or sets the description
        /// </summary>
        public string Description { get; set; }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<Parameter> m_parameters;

        /// <summary>
        /// Gets or sets the parameters list
        /// </summary>
        public List<Parameter> Parameters
        {
            get
            {
                return m_parameters ?? (m_parameters = new List<Parameter>());
            }
            set
            {
                m_parameters = value;
            }
        }
    }
}
