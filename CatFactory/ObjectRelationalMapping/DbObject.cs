using System.Diagnostics;

namespace CatFactory.ObjectRelationalMapping
{
    /// <summary>
    /// Represents a Database object (Table, View, Table Function, Scalar Function, Stored Procedure, Sequence, etc)
    /// </summary>
    [DebuggerDisplay("Type={Type}, FullName={FullName}")]
    public class DbObject : IDbObject
    {
        #region [ Constructors ]

        /// <summary>
        /// Initializes a new instance of <see cref="DbObject"/> class
        /// </summary>
        public DbObject()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="DbObject"/> class
        /// </summary>
        /// <param name="schema">Schema name</param>
        /// <param name="name">Name</param>
        public DbObject(string schema, string name)
        {
            Schema = schema;
            Name = name;
        }

        /// <summary>
        /// Initializes a new instance of <see cref="DbObject"/> class
        /// </summary>
        /// <param name="dataSource">Data source</param>
        /// <param name="databaseName">Database name</param>
        /// <param name="schema">Schema name</param>
        /// <param name="name">Name</param>
        public DbObject(string dataSource, string databaseName, string schema, string name)
        {
            DataSource = dataSource;
            DatabaseName = databaseName;
            Schema = schema;
            Name = name;
        }

        #endregion

        #region [ Properties ]

        /// <summary>
        /// Data Source or Server
        /// </summary>
        public string DataSource { get; set; }

        /// <summary>
        /// Gets or sets the database name
        /// </summary>
        public string DatabaseName { get; set; }

        #endregion

        #region [ Members of IDbObject ]

        /// <summary>
        /// Gets or sets the schema for current database object
        /// </summary>
        public string Schema { get; set; }

        /// <summary>
        /// Gets or sets the name for current database object
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets the full name for current database object
        /// </summary>
        public string FullName
            => string.IsNullOrEmpty(Schema) ? Name : string.Format("{0}.{1}", Schema, Name);

        /// <summary>
        /// Gets or sets the type for current database object
        /// </summary>
        public string Type { get; set; }

        #endregion
    }
}
