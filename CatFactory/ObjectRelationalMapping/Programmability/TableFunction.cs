using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace CatFactory.ObjectRelationalMapping.Programmability
{
    /// <summary>
    /// Represents a table function
    /// </summary>
    [DebuggerDisplay("FullName={FullName}, Parameters={Parameters.Count}")]
    public class TableFunction : DbObject, ITableFunction
    {
        #region [ Fields ]

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<Column> m_columns;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<Parameter> m_parameters;

        #endregion

        #region [ Constructors ]

        /// <summary>
        /// Initializes a new instance of <see cref="TableFunction"/> class
        /// </summary>
        public TableFunction()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="TableFunction"/> class
        /// </summary>
        /// <param name="schema">Schema</param>
        /// <param name="name">Name</param>
        public TableFunction(string schema, string name)
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
        public TableFunction(string dataSource, string catalog, string schema, string name)
            : base(dataSource, catalog, schema, name)
        {
        }

        #endregion

        #region [ Members of ITableFunction ]

        /// <summary>
        /// Gets or sets a column by index
        /// </summary>
        /// <param name="index">Column's index</param>
        /// <returns>A <see cref="Column"/> from current table</returns>
        public Column this[int index]
        {
            get => Columns[index];
            set => Columns[index] = value;
        }

        /// <summary>
        /// Gets or sets a column by name
        /// </summary>
        /// <param name="name">Column name</param>
        /// <returns>A <see cref="Column"/> from current table function</returns>
        public Column this[string name]
        {
            get => Columns.First(item => item.Name == name);
            set
            {
                for (var i = 0; i < Columns.Count; i++)
                {
                    var column = Columns[i];

                    if (column.Name == name)
                        column = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets the description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the columns list
        /// </summary>
        public List<Column> Columns
        {
            get => m_columns ?? (m_columns = new List<Column>());
            set => m_columns = value;
        }

        /// <summary>
        /// Gets or sets the parameters list
        /// </summary>
        public List<Parameter> Parameters
        {
            get => m_parameters ?? (m_parameters = new List<Parameter>());
            set => m_parameters = value;
        }

        /// <summary>
        /// Gets or sets identity (auto increment)
        /// </summary>
        public Identity Identity { get; set; }

        #endregion
    }
}
