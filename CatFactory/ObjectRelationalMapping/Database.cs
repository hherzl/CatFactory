using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Xml.Serialization;
using CatFactory.Diagnostics;
using CatFactory.ObjectRelationalMapping.Validation;

namespace CatFactory.ObjectRelationalMapping
{
    /// <summary>
    /// Represents a database model
    /// </summary>
    /// <remarks>
    /// //todo: refactor to work with case sensitive database and/or collations as indicated by the data
    /// <![CDATA[  https://www.webucator.com/how-to/how-check-case-sensitivity-sql-server.cfm  ]]>
    /// </remarks>
    [DebuggerDisplay("Name={Name}, DbObjects={DbObjects.Count}, Tables={Tables.Count}, Views={Views.Count}")]
    public class Database : IDatabase
    {
        #region [ Fields ]

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<DbObject> m_dbObjects;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private IDatabaseNamingConvention m_namingConvention;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<DatabaseTypeMap> m_databaseTypeMaps;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<Table> m_tables;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<View> m_views;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private dynamic m_importBag;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<IDatabaseValidator> m_databaseValidators;

        #endregion

        #region [ Constructors ]

        /// <summary>
        /// Initializes a new instance of <see cref="Database"/> class
        /// </summary>
        public Database()
        {
        }

        #endregion

        #region [ Properties ]

        /// <summary>
        /// Gets or sets the server name
        /// </summary>
        public string ServerName { get; set; }

        /// <summary>
        /// Gets or sets the name for database
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the default schema for database
        /// </summary>
        public string DefaultSchema { get; set; }

        /// <summary>
        /// Gets or sets if database supports transactions
        /// </summary>
        public bool SupportTransactions { get; set; }

        /// <summary>
        /// Gets or sets Db objects
        /// </summary>
        public List<DbObject> DbObjects
        {
            get => m_dbObjects ?? (m_dbObjects = new List<DbObject>());
            set => m_dbObjects = value;
        }

        /// <summary>
        /// Gets or sets naming convention for database
        /// </summary>
        [XmlIgnore]
        public IDatabaseNamingConvention NamingConvention
        {
            get => m_namingConvention ?? (m_namingConvention = new DatabaseNamingConvention());
            set => m_namingConvention = value;
        }

        /// <summary>
        /// Gets or sets database type maps (data type equivalents)
        /// </summary>
        public List<DatabaseTypeMap> DatabaseTypeMaps
        {
            get => m_databaseTypeMaps ?? (m_databaseTypeMaps = new List<DatabaseTypeMap>());
            set => m_databaseTypeMaps = value;
        }

        /// <summary>
        /// Gets or sets the tables
        /// </summary>
        public List<Table> Tables
        {
            get => m_tables ?? (m_tables = new List<Table>());
            set => m_tables = value;
        }

        /// <summary>
        /// Gets or sets the views
        /// </summary>
        public List<View> Views
        {
            get => m_views ?? (m_views = new List<View>());
            set => m_views = value;
        }

        /// <summary>
        /// Gets or sets the data source
        /// </summary>
        [Obsolete("Prefer ServerName over DataSource")]
        public string DataSource
        {
            get => ServerName;
            set => ServerName = value;
        }

        /// <summary>
        /// Gets or sets the catalog (Database name)
        /// </summary>
        [Obsolete("Prefer Name over Catalog")]
        public string Catalog
        {
            get => Name;
            set => Name = value;
        }

        /// <summary>
        /// Gets or sets the extension data for import
        /// </summary>
        [XmlIgnore]
        public dynamic ImportBag
        {
            get => m_importBag ?? (m_importBag = new ExpandoObject());
            set => m_importBag = value;
        }

        /// <summary>
        /// Gets or sets the database validators
        /// </summary>
        [XmlIgnore]
        public List<IDatabaseValidator> DatabaseValidators
        {
            get => m_databaseValidators ?? (m_databaseValidators = new List<IDatabaseValidator>());
            set => m_databaseValidators = value;
        }

        #endregion

        #region [ Methods ]

        /// <summary>
        /// Gets database objects by name
        /// </summary>
        /// <param name="name">Db object name</param>
        /// <returns>A <see cref="List{DbObject}"/></returns>
        public virtual List<DbObject> GetDbObjectsByName(string name)
            => DbObjects.Where(item => item.Schema == name).ToList();

        /// <summary>
        /// Gets database objects by schema
        /// </summary>
        /// <param name="schema">Schema name</param>
        /// <returns>A <see cref="List{DbObject}"/></returns>
        public virtual List<DbObject> GetDbObjectsBySchema(string schema)
            => DbObjects.Where(item => item.Schema == schema).ToList();

        /// <summary>
        /// Gets a table from table list by name
        /// </summary>
        /// <param name="name">Name for table</param>
        /// <returns>An instance of <see cref="Table"/> class</returns>
        /// <remarks>
        /// TODO refactor to work with case sensitive database and/or collations as indicated by the data
        /// <![CDATA[  https://www.webucator.com/how-to/how-check-case-sensitivity-sql-server.cfm  ]]>
        /// </remarks>
        public virtual Table FindTable(string name)
        {
            string Join4(Table item)
                => string.Join(".", new string[] { item.DataSource, item.DatabaseName, item.Schema, item.Name });

            string Join3(Table item)
                => string.Join(".", new string[] { item.DatabaseName, item.Schema, item.Name });

            string Join2(Table item)
                => string.Join(".", new string[] { item.Schema, item.Name });

            var table = Tables.FirstOrDefault(item => string.Equals(Join4(item: item), name, StringComparison.OrdinalIgnoreCase)
                || string.Equals(Join3(item: item), name, StringComparison.OrdinalIgnoreCase)
                || string.Equals(Join2(item: item), name, StringComparison.OrdinalIgnoreCase));

            if (table == null)
                table = Tables.FirstOrDefault(item => string.Join(".", new string[] { Name, item.Schema, item.Name }) == name);

            return table;
        }

        /// <summary>
        /// Gets tables from table list by schema
        /// </summary>
        /// <param name="schema">Schema</param>
        /// <returns>A <see cref="IEnumerable{Table}"/></returns>
        public virtual IEnumerable<Table> FindTablesBySchema(string schema)
            => Tables.Where(item => item.Schema == schema);

        /// <summary>
        /// Gets tables from table list by name
        /// </summary>
        /// <param name="name">Name for tables</param>
        /// <returns>A <see cref="IEnumerable{Table}"/></returns>
        public virtual IEnumerable<Table> FindTablesByName(string name)
            => Tables.Where(item => item.Name == name);

        /// <summary>
        /// Gets view from view list by name
        /// </summary>
        /// <param name="name">Name for view</param>
        /// <returns>A <see cref="View"/></returns>
        public virtual View FindView(string name)
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
        /// <returns>A <see cref="IEnumerable{View}"/></returns>
        public virtual IEnumerable<View> FindViewsBySchema(string schema)
            => Views.Where(item => item.Schema == schema);

        /// <summary>
        /// Gets a view from view list by name
        /// </summary>
        /// <param name="name">Name for views</param>
        /// <returns>A <see cref="IEnumerable{View}"/></returns>
        public virtual IEnumerable<View> FindViewsByName(string name)
            => Views.Where(item => item.Name == name);

        /// <summary>
        /// Gets validations for current database instance
        /// </summary>
        /// <returns>A <see cref="IEnumerable{ValidationResult}"/></returns>
        public virtual IEnumerable<ValidationResult> Validate()
        {
            foreach (var item in DatabaseValidators)
            {
                yield return item.Validate(this);
            }
        }

        #endregion
    }
}
