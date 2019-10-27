using System;
using System.Diagnostics;

namespace CatFactory.ObjectRelationalMapping
{
    /// <summary>
    /// Represents a Database Object (Table, View, Table Function, Scalar Function, Stored Procedure, etc)
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
        /// <param name="serverName">Server name</param>
        /// <param name="databaseName">Database name</param>
        /// <param name="schema">Schema name</param>
        /// <param name="name">Name</param>
        public DbObject(string serverName, string databaseName, string schema, string name)
        {
            ServerName = serverName;
            DatabaseName = databaseName;
            Schema = schema;
            Name = name;
        }

        #endregion

        #region [ Properties ]

        /// <summary>
        /// Gets or sets the server name
        /// </summary>
        public string ServerName { get; set; }

        /// <summary>
        /// Gets or sets the database name
        /// </summary>
        public string DatabaseName { get; set; }

        /// <summary>
        /// Data Source or Server
        /// </summary>
        [Obsolete("Prefer server name over datasource")]
        public string DataSource
        {
            get => ServerName;
            set => ServerName = value;
        }

        /// <summary>
        /// Catalog or Database Name
        /// </summary>
        [Obsolete("Prefer database name over catalog")]
        public string Catalog
        {
            get => DatabaseName;
            set => DatabaseName = value;
        }

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
