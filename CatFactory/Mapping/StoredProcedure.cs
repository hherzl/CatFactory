using System.Collections.Generic;
using System.Diagnostics;

namespace CatFactory.Mapping
{
    /// <summary>
    /// Represents a stored procedure
    /// </summary>
    [DebuggerDisplay("FullName={FullName}, Parameters={Parameters.Count}")]
    public class StoredProcedure : DbObject
    {
        /// <summary>
        /// Initializes a new instance of <see cref="StoredProcedure"/> class
        /// </summary>
        public StoredProcedure()
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

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<FirstResultSetForObject> m_firstResultSetsForObject;

        /// <summary>
        /// Gets or sets the sequence for first result sets for object
        /// </summary>
        public List<FirstResultSetForObject> FirstResultSetsForObject
        {
            get
            {
                return m_firstResultSetsForObject ?? (m_firstResultSetsForObject = new List<FirstResultSetForObject>());
            }
            set
            {
                m_firstResultSetsForObject = value;
            }
        }
    }
}
