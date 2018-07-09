using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace CatFactory.Mapping
{
    /// <summary>
    /// Represents a table function
    /// </summary>
    [DebuggerDisplay("FullName={FullName}, Parameters={Parameters.Count}")]
    public class TableFunction : DbObject, ITableFunction
    {
        /// <summary>
        /// Initializes a new instance of <see cref="TableFunction"/> class
        /// </summary>
        public TableFunction()
        {
        }

        /// <summary>
        /// Gets or sets the description
        /// </summary>
        public string Description { get; set; }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<Column> m_columns;

        /// <summary>
        /// Gets or sets the columns list
        /// </summary>
        public List<Column> Columns
        {
            get
            {
                return m_columns ?? (m_columns = new List<Column>());
            }
            set
            {
                m_columns = value;
            }
        }

        /// <summary>
        /// Gets a column by name
        /// </summary>
        /// <param name="name">Name for column</param>
        /// <returns>A column as selection result</returns>
        public Column GetColumn(string name)
            => Columns.First(item => item.Name == name);

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

        /// <summary>
        /// Gets or sets identity (auto increment)
        /// </summary>
        public Identity Identity { get; set; }
    }
}
