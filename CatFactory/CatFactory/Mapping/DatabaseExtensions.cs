using System;
using System.Collections.Generic;
using System.Linq;

namespace CatFactory.Mapping
{
    /// <summary>
    /// Contains extension methods for <see cref="CatFactory.Mapping.Database"/> class
    /// </summary>
    public static class DatabaseExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="database"></param>
        /// <returns></returns>
        public static Database AddDbObjectsFromTables(this Database database)
        {
            foreach (var table in database.Tables)
            {
                database.DbObjects.Add(new DbObject { Schema = table.Schema, Name = table.Name, Type = "table" });
            }

            return database;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="database"></param>
        /// <returns></returns>
        public static Database AddDbObjectsFromViews(this Database database)
        {
            foreach (var view in database.Views)
            {
                database.DbObjects.Add(new DbObject { Schema = view.Schema, Name = view.Name, Type = "view" });
            }

            return database;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="database"></param>
        /// <param name="columns"></param>
        /// <param name="exclusions"></param>
        /// <returns></returns>
        public static Database AddColumnsForTables(this Database database, Column[] columns, params string[] exclusions)
        {
            foreach (var table in database.Tables)
            {
                if (exclusions != null && exclusions.Contains(table.FullName))
                    continue;

                foreach (var column in columns)
                {
                    if (!table.Columns.Contains(column))
                        table.Columns.Add(column);
                }
            }

            return database;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="database"></param>
        /// <param name="column"></param>
        /// <param name="exclusions"></param>
        /// <returns></returns>
        public static Database AddColumnForTables(this Database database, Column column, params string[] exclusions)
            => AddColumnsForTables(database, new Column[] { column }, exclusions);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="database"></param>
        /// <param name="exclusions"></param>
        /// <returns></returns>
        public static Database SetIdentityForTables(this Database database, params string[] exclusions)
        {
            foreach (var table in database.Tables)
            {
                if (exclusions != null && exclusions.Contains(table.FullName))
                    continue;

                if (table.Identity == null && table.Columns.Count > 0)
                    table.Identity = new Identity(table.Columns[0].Name, 1, 1);
            }

            return database;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="database"></param>
        /// <param name="mappings"></param>
        /// <returns></returns>
        public static Database SetMappings(this Database database, IEnumerable<DatabaseTypeMap> mappings)
        {
            database.Mappings.AddRange(mappings);

            return database;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="database"></param>
        /// <param name="table"></param>
        /// <returns></returns>
        public static bool PrimaryKeyIsGuid(this Database database, ITable table)
            => table.PrimaryKey != null && table.PrimaryKey.Key.Count == 1 && database.ColumnIsGuid(table.Columns.First()) ? true : false;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="database"></param>
        /// <param name="column"></param>
        /// <returns></returns>
        public static bool ColumnIsBoolean(this Database database, Column column)
            => database.Mappings.Where(item => item.DatabaseType == column.Type && item.ClrFullNameType == typeof(bool).FullName).Count() == 0 ? false : true;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="database"></param>
        /// <param name="column"></param>
        /// <returns></returns>
        public static bool ColumnIsDateTime(this Database database, Column column)
            => database.Mappings.Where(item => item.DatabaseType == column.Type && item.ClrFullNameType == typeof(DateTime).FullName).Count() == 0 ? false : true;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="database"></param>
        /// <param name="column"></param>
        /// <returns></returns>
        public static bool ColumnIsDecimal(this Database database, Column column)
            => database.Mappings.Where(item => item.DatabaseType == column.Type && item.ClrFullNameType == typeof(decimal).FullName).Count() == 0 ? false : true;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="database"></param>
        /// <param name="column"></param>
        /// <returns></returns>
        public static bool ColumnIsDouble(this Database database, Column column)
            => database.Mappings.Where(item => item.DatabaseType == column.Type && item.ClrFullNameType == typeof(double).FullName).Count() == 0 ? false : true;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="database"></param>
        /// <param name="column"></param>
        /// <returns></returns>
        public static bool ColumnIsGuid(this Database database, Column column)
            => database.Mappings.Where(item => item.DatabaseType == column.Type && item.ClrFullNameType == typeof(Guid).FullName).Count() == 0 ? false : true;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="database"></param>
        /// <param name="column"></param>
        /// <returns></returns>
        public static bool ColumnIsInt16(this Database database, Column column)
            => database.Mappings.Where(item => item.DatabaseType == column.Type && item.ClrFullNameType == typeof(short).FullName).Count() == 0 ? false : true;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="database"></param>
        /// <param name="column"></param>
        /// <returns></returns>
        public static bool ColumnIsInt32(this Database database, Column column)
            => database.Mappings.Where(item => item.DatabaseType == column.Type && item.ClrFullNameType == typeof(int).FullName).Count() == 0 ? false : true;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="database"></param>
        /// <param name="column"></param>
        /// <returns></returns>
        public static bool ColumnIsInt64(this Database database, Column column)
            => database.Mappings.Where(item => item.DatabaseType == column.Type && item.ClrFullNameType == typeof(long).FullName).Count() == 0 ? false : true;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="database"></param>
        /// <param name="column"></param>
        /// <returns></returns>
        public static bool ColumnIsSingle(this Database database, Column column)
            => database.Mappings.Where(item => item.DatabaseType == column.Type && item.ClrFullNameType == typeof(float).FullName).Count() == 0 ? false : true;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="database"></param>
        /// <param name="column"></param>
        /// <returns></returns>
        public static bool ColumnIsString(this Database database, Column column)
            => database.Mappings.Where(item => item.DatabaseType == column.Type && item.ClrFullNameType == typeof(string).FullName).Count() == 0 ? false : true;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="database"></param>
        /// <param name="column"></param>
        /// <returns></returns>
        public static DatabaseTypeMap ResolveType(this Database database, Column column)
            => database.Mappings.FirstOrDefault(item => item.DatabaseType == column.Type);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="database"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static DatabaseTypeMap ResolveType(this Database database, string type)
            => database.Mappings.FirstOrDefault(item => item.DatabaseType == type);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="database"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static IEnumerable<DatabaseTypeMap> GetTypeMaps(this Database database, Type type)
            => database.Mappings.Where(item => item.GetClrType() == type);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="database"></param>
        /// <param name="exclusions"></param>
        /// <returns></returns>
        public static Database SetPrimaryKeyToTables(this Database database, params string[] exclusions)
        {
            foreach (var table in database.Tables)
            {
                if (exclusions != null && exclusions.Contains(table.FullName))
                    continue;

                if (table.PrimaryKey == null && table.Columns.Count > 0)
                    table.PrimaryKey = new PrimaryKey(table.Columns.First().Name);
            }

            return database;
        }
    }
}
