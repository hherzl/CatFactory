using System.Collections.Generic;

namespace CatFactory.ObjectRelationalMapping
{
    /// <summary>
    /// Represents the abstract model for databases
    /// </summary>
    public interface IDatabase
    {
        /// <summary>
        /// Gets or sets the server name
        /// </summary>
        string ServerName { get; set; }

        /// <summary>
        /// Gets or sets the name
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Gets or sets the description
        /// </summary>
        string Description { get; set; }

        /// <summary>
        /// Gets or sets the default schema for database
        /// </summary>
        string DefaultSchema { get; set; }

        /// <summary>
        /// Gets or sets if database supports transactions
        /// </summary>
        bool SupportTransactions { get; set; }

        /// <summary>
        /// Gets or sets Db objects
        /// </summary>
        List<DbObject> DbObjects { get; set; }

        /// <summary>
        /// Gets or sets naming convention for database
        /// </summary>
        IDatabaseNamingConvention NamingConvention { get; set; }

        /// <summary>
        /// Gets or sets database type maps (data type equivalents)
        /// </summary>
        List<DatabaseTypeMap> DatabaseTypeMaps { get; set; }

        /// <summary>
        /// Gets or sets the extension data for import
        /// </summary>
        dynamic ImportBag { get; set; }

        /// <summary>
        /// Gets database objects by name
        /// </summary>
        /// <param name="name">Db object name</param>
        /// <returns>A <see cref="List{DbObject}"/></returns>
        List<DbObject> GetDbObjectsByName(string name);

        /// <summary>
        /// Gets database objects by schema
        /// </summary>
        /// <param name="schema">Schema name</param>
        /// <returns>A <see cref="List{DbObject}"/></returns>
        List<DbObject> GetDbObjectsBySchema(string schema);
    }
}
