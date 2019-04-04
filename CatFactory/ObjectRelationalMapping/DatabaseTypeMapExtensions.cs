using System;
using System.Collections.Generic;
using System.Linq;

namespace CatFactory.ObjectRelationalMapping
{
    /// <summary>
    /// Provides extensions methods for <see cref="DatabaseTypeMap"/> class
    /// </summary>
    public static class DatabaseTypeMapExtensions
    {
        /// <summary>
        /// Gets the CLR type for database type instance
        /// </summary>
        /// <param name="databaseTypeMap">Database type</param>
        /// <returns>An instance of <see cref="Type"/> class that represents an equivalence for <see cref="DatabaseTypeMap"/> instance</returns>
        public static Type GetClrType(this DatabaseTypeMap databaseTypeMap)
            => databaseTypeMap.HasClrFullNameType ? Type.GetType(databaseTypeMap.ClrFullNameType) : null;

        /// <summary>
        /// Gets the parent type for database type instance
        /// </summary>
        /// <param name="databaseTypeMap">Database type</param>
        /// <param name="mappings">A sequence with database types</param>
        /// <returns>An instance of <see cref="Type"/> class that represents an equivalence for <see cref="DatabaseTypeMap"/> instance</returns>
        public static DatabaseTypeMap GetParentType(this DatabaseTypeMap databaseTypeMap, IEnumerable<DatabaseTypeMap> mappings)
            => mappings.FirstOrDefault(item => databaseTypeMap.ParentDatabaseType == item.DatabaseType);
    }
}
