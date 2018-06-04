using System;

namespace CatFactory.Mapping
{
    /// <summary>
    /// Provides extensions methods to reflect CLR
    /// </summary>
    public static class DatabaseTypeMapExtensions
    {
        /// <summary>
        /// Gets the CLR type for database type provided
        /// </summary>
        /// <param name="dbTypeMap">Database type</param>
        /// <returns>Returns a <see cref="System.Type"/> instance that represents an equivalence for <see cref="CatFactory.Mapping.DatabaseTypeMap"/> provided</returns>
        public static Type GetClrType(this DatabaseTypeMap dbTypeMap)
            => dbTypeMap.HasClrFullNameType ? Type.GetType(dbTypeMap.ClrFullNameType) : null;
    }
}
