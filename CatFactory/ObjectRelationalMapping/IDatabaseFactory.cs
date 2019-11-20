using System.Collections.Generic;
using System.Threading.Tasks;

namespace CatFactory.ObjectRelationalMapping
{
    /// <summary>
    /// Represents a factory to import an existing database from DBMS
    /// </summary>
    public interface IDatabaseFactory
    {
        /// <summary>
        /// Gets the sequence of database type maps
        /// </summary>
        IEnumerable<DatabaseTypeMap> DatabaseTypeMaps { get; }

        /// <summary>
        /// Imports an existing database
        /// </summary>
        /// <returns>A <see cref="Database"/> instance that represents an existing database in DBMS</returns>
        Database Import();

        /// <summary>
        /// Imports an existing database in async mode
        /// </summary>
        /// <returns>A <see cref="Database"/> instance that represents an existing database in DBMS</returns>
        Task<Database> ImportAsync();
    }
}
