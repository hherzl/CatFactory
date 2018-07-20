using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Xml.Serialization;

namespace CatFactory.Mapping
{
    /// <summary>
    /// Represents a database
    /// </summary>
    [DebuggerDisplay("Name={Name}, DbObjects={DbObjects.Count}, Tables={Tables.Count}, Views={Views.Count}")]
    public class Database
    {
        /// <summary>
        /// Initializes a new instance of <see cref="Database"/> class
        /// </summary>
        public Database()
        {
        }

        /// <summary>
        /// Gets or sets the name for database
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the default schema for database
        /// </summary>
        public string DefaultSchema { get; set; }

        /// <summary>
        /// Gets or sets if database supports transactions
        /// </summary>
        public bool SupportTransactions { get; set; }

        /// <summary>
        /// Gets or sets the description
        /// </summary>
        public string Description { get; set; }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<DbObject> m_dbObjects;

        /// <summary>
        /// Gets or sets Db objects
        /// </summary>
        public List<DbObject> DbObjects
        {
            get
            {
                return m_dbObjects ?? (m_dbObjects = new List<DbObject>());
            }
            set
            {
                m_dbObjects = value;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private IDatabaseNamingConvention m_namingConvention;

        /// <summary>
        /// Gets or sets naming convention for database
        /// </summary>
        [XmlIgnore]
        public IDatabaseNamingConvention NamingConvention
        {
            get
            {
                return m_namingConvention ?? (m_namingConvention = new DatabaseNamingConvention());
            }
            set
            {
                m_namingConvention = value;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<Table> m_tables;

        /// <summary>
        /// Gets or sets tables
        /// </summary>
        public List<Table> Tables
        {
            get
            {
                return m_tables ?? (m_tables = new List<Table>());
            }
            set
            {
                m_tables = value;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<View> m_views;

        /// <summary>
        /// Gets or sets views
        /// </summary>
        public List<View> Views
        {
            get
            {
                return m_views ?? (m_views = new List<View>());
            }
            set
            {
                m_views = value;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<StoredProcedure> m_storedProcedures;

        /// <summary>
        /// Gets or sets store procedures
        /// </summary>
        public List<StoredProcedure> StoredProcedures
        {
            get
            {
                return m_storedProcedures ?? (m_storedProcedures = new List<StoredProcedure>());
            }
            set
            {
                m_storedProcedures = value;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<ScalarFunction> m_scalarFunctions;

        /// <summary>
        /// Gets or sets scalar functions
        /// </summary>
        public List<ScalarFunction> ScalarFunctions
        {
            get
            {
                return m_scalarFunctions ?? (m_scalarFunctions = new List<ScalarFunction>());
            }
            set
            {
                m_scalarFunctions = value;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<TableFunction> m_tableFunctions;

        /// <summary>
        /// Gets or sets table functions
        /// </summary>
        public List<TableFunction> TableFunctions
        {
            get
            {
                return m_tableFunctions ?? (m_tableFunctions = new List<TableFunction>());
            }
            set
            {
                m_tableFunctions = value;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<DatabaseTypeMap> m_mappings;

        /// <summary>
        /// Gets or sets mappings (data type equivalents)
        /// </summary>
        public List<DatabaseTypeMap> Mappings
        {
            get
            {
                return m_mappings ?? (m_mappings = new List<DatabaseTypeMap>());
            }
            set
            {
                m_mappings = value;
            }
        }

        /// <summary>
        /// Gets Db objects by schema
        /// </summary>
        /// <param name="schema">Schema name</param>
        /// <returns>A list of DbObject</returns>
        public virtual List<DbObject> GetDbObjectsBySchema(string schema)
            => DbObjects.Where(item => item.Schema == schema).ToList();

        /// <summary>
        /// Gets a table from table list by name
        /// </summary>
        /// <param name="name">Name for table</param>
        /// <returns>A table</returns>
        public virtual ITable FindTable(string name)
        {
            var table = Tables.FirstOrDefault(item => string.Join(".", new string[] { item.Schema, item.Name }) == name);

            if (table == null)
                table = Tables.FirstOrDefault(item => string.Join(".", new string[] { Name, item.Schema, item.Name }) == name);

            return table;
        }

        /// <summary>
        /// Gets tables from table list by schema
        /// </summary>
        /// <param name="schema">Schema name</param>
        /// <returns>A sequence of tables</returns>
        public virtual IEnumerable<ITable> FindTablesBySchema(string schema)
            => Tables.Where(item => item.Schema == schema);

        /// <summary>
        /// Gets tables from table list by name
        /// </summary>
        /// <param name="name">Name for tables</param>
        /// <returns>A sequence of tables</returns>
        public virtual IEnumerable<ITable> FindTablesByName(string name)
            => Tables.Where(item => item.Name == name);

        /// <summary>
        /// Gets view from view list by name
        /// </summary>
        /// <param name="name">Name for view</param>
        /// <returns>A view</returns>
        public virtual IView FindView(string name)
        {
            var view = Views.FirstOrDefault(item => string.Join(".", new string[] { item.Schema, item.Name }) == name);

            if (view == null)
                view = Views.FirstOrDefault(item => string.Join(".", new string[] { Name, item.Schema, item.Name }) == name);

            return view;
        }

        /// <summary>
        /// Gets views from views list by name
        /// </summary>
        /// <param name="schema">Schema name</param>
        /// <returns>A sequence of views</returns>
        public virtual IEnumerable<IView> FindViewsBySchema(string schema)
            => Views.Where(item => item.Schema == schema);

        /// <summary>
        /// Gets a view from view list by name
        /// </summary>
        /// <param name="name">Name for views</param>
        /// <returns>A sequence of views</returns>
        public virtual IEnumerable<IView> FindViewsByName(string name)
            => Views.Where(item => item.Name == name);
    }
}
