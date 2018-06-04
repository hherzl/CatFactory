using System.Collections.Generic;
using System.Diagnostics;

namespace CatFactory.Mapping
{
    /// <summary>
    /// Represents a scalar function
    /// </summary>
    [DebuggerDisplay("FullName={FullName}, Parameters={Parameters.Count}")]
    public class ScalarFunction : IDbObject
    {
        /// <summary>
        /// Initializes a new instance of <see cref="CatFactory.Mapping.ScalarFunction"/> class
        /// </summary>
        public ScalarFunction()
        {
        }

        /// <summary>
        /// Gets or sets the schema
        /// </summary>
        public string Schema { get; set; }

        /// <summary>
        /// Gets or sets the name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets full name
        /// </summary>
        public string FullName
            => string.IsNullOrEmpty(Schema) ? Name : string.Format("{0}.{1}", Schema, Name);

        /// <summary>
        /// Gets or sets the type
        /// </summary>
        public string Type { get; set; }

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
