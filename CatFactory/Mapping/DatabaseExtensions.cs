using System;
using System.Collections.Generic;
using System.Linq;

namespace CatFactory.Mapping
{
    /// <summary>
    /// Contains extension methods for <see cref="Database"/> class
    /// </summary>
    public static class DatabaseExtensions
    {
        /// <summary>
        /// Validates if a Db object has the default schema
        /// </summary>
        /// <param name="database"><see cref="Database"/> instance</param>
        /// <param name="dbObj"><see cref="IDbObject"/> instance</param>
        /// <returns>True if <see cref="IDbObject"/> has database's default schema, otherwise false</returns>
        public static bool HasDefaultSchema(this Database database, IDbObject dbObj)
            => string.IsNullOrEmpty(dbObj.Schema) || string.Compare(dbObj.Schema, database.DefaultSchema, true) == 0;

        /// <summary>
        /// Adds all tables as db objects in database
        /// </summary>
        /// <param name="database"><see cref="Database"/> instance</param>
        /// <returns><see cref="Database"/> instance</returns>
        public static Database AddDbObjectsFromTables(this Database database)
        {
            foreach (var table in database.Tables)
                database.DbObjects.Add(new DbObject { Schema = table.Schema, Name = table.Name, Type = "table" });

            return database;
        }

        /// <summary>
        /// Adds all views as db objects in database
        /// </summary>
        /// <param name="database"><see cref="Database"/> instance</param>
        /// <returns><see cref="Database"/> instance</returns>
        public static Database AddDbObjectsFromViews(this Database database)
        {
            foreach (var view in database.Views)
                database.DbObjects.Add(new DbObject { Schema = view.Schema, Name = view.Name, Type = "view" });

            return database;
        }

        /// <summary>
        /// Adds columns array for all tables in <see cref="Database"/> instance
        /// </summary>
        /// <param name="database"><see cref="Database"/> instance</param>
        /// <param name="columns">Array of <see cref="Column"/> class</param>
        /// <param name="exclusions">Exclusions for tables in <see cref="Database"/> instance</param>
        /// <returns><see cref="Database"/> instance</returns>
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
        /// Adds a <see cref="Column"/> instance in all tables for <see cref="Database"/> instance
        /// </summary>
        /// <param name="database"><see cref="Database"/> instance</param>
        /// <param name="column"><see cref="Column"/> instance</param>
        /// <param name="exclusions">Exclusions for tables in <see cref="Database"/> instance</param>
        /// <returns><see cref="Database"/> instance</returns>
        public static Database AddColumnForTables(this Database database, Column column, params string[] exclusions)
            => AddColumnsForTables(database, new Column[] { column }, exclusions);

        /// <summary>
        /// Sets identity for tables in <see cref="Database"/> instance
        /// </summary>
        /// <param name="database"><see cref="Database"/> instance</param>
        /// <param name="exclusions">Exclusions for tables in <see cref="Database"/> instance</param>
        /// <returns><see cref="Database"/> instance</returns>
        public static Database SetIdentityForTables(this Database database, params string[] exclusions)
        {
            foreach (var table in database.Tables)
            {
                if (exclusions != null && exclusions.Contains(table.FullName))
                    continue;

                if (table.Identity == null && table.Columns.Count > 0 && database.ColumnIsNumber(table.Columns[0]))
                    table.Identity = new Identity(table.Columns[0].Name, 1, 1);
            }

            return database;
        }

        /// <summary>
        /// Sets <see cref="PrimaryKey"/> in <see cref="Table"/> collection for <see cref="Database"/> instance
        /// </summary>
        /// <param name="database"><see cref="Database"/> instance</param>
        /// <param name="exclusions">Exclusions for tables in <see cref="Database"/> instance</param>
        /// <returns><see cref="Database"/> instance</returns>
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

        /// <summary>
        /// Adds a relation between target and source tables
        /// </summary>
        /// <param name="database"><see cref="Database"/> instance</param>
        /// <param name="target">Target table</param>
        /// <param name="key">Key for relation: columns that represent key</param>
        /// <param name="source">Source table</param>
        /// <returns><see cref="Database"/> instance</returns>
        public static Database AddRelation(this Database database, ITable target, string[] key, ITable source)
        {
            target.ForeignKeys.Add(new ForeignKey(key)
            {
                ConstraintName = database.NamingConvention.GetForeignKeyConstraintName(target, key, source),
                References = source.FullName,
                Child = target.FullName
            });

            return database;
        }

        /// <summary>
        /// Link all tables in database
        /// </summary>
        /// <param name="database"><see cref="Database"/> instance</param>
        /// <returns><see cref="Database"/> instance</returns>
        public static Database LinkTables(this Database database)
        {
            foreach (var table in database.Tables)
            {
                foreach (var column in table.Columns)
                {
                    if (table.PrimaryKey?.Key.Count == 1 && table.PrimaryKey.Key.Contains(column.Name))
                        continue;

                    foreach (var parentTable in database.Tables)
                    {
                        if (table.FullName == parentTable.FullName)
                            continue;

                        if (parentTable.PrimaryKey != null && parentTable.PrimaryKey.Key.Contains(column.Name))
                        {
                            table.ForeignKeys.Add(new ForeignKey(column.Name)
                            {
                                ConstraintName = database.NamingConvention.GetForeignKeyConstraintName(table, new string[] { column.Name }, parentTable),
                                References = string.Format("{0}.{1}", database.Name, parentTable.FullName),
                                Child = table.FullName
                            });
                        }
                    }
                }
            }

            return database;
        }

        /// <summary>
        /// Validates if <see cref="Table"/> instance has a <see cref="Guid"/> as <see cref="PrimaryKey"/>
        /// </summary>
        /// <param name="database"><see cref="Database"/> instance</param>
        /// <param name="table"><see cref="Table"/> instance</param>
        /// <returns>True if <see cref="Table"/> instance has <see cref="PrimaryKey"/>, otherwise false</returns>
        public static bool PrimaryKeyIsGuid(this Database database, ITable table)
            => table.PrimaryKey != null && table.PrimaryKey.Key.Count == 1 && database.ColumnIsGuid(table.Columns.First()) ? true : false;

        /// <summary>
        /// Validates if column database type is <see cref="Boolean"/>
        /// </summary>
        /// <param name="database"><see cref="Database"/> instance</param>
        /// <param name="column"><see cref="Column"/> database</param>
        /// <returns>True if <see cref="Column"/> database type is <see cref="Boolean"/>, otherwise false</returns>
        public static bool ColumnIsBoolean(this Database database, Column column)
            => database.DatabaseTypeMaps.Where(item => item.DatabaseType == column.Type && item.ClrFullNameType == typeof(bool).FullName).Count() == 0 ? false : true;

        /// <summary>
        /// Validates if column database type is <see cref="Byte"/>
        /// </summary>
        /// <param name="database"><see cref="Database"/> instance</param>
        /// <param name="column"><see cref="Column"/> database</param>
        /// <returns>True if <see cref="Column"/> database type is <see cref="Byte"/>, otherwise false</returns>
        public static bool ColumnIsByte(this Database database, Column column)
            => database.DatabaseTypeMaps.Where(item => item.DatabaseType == column.Type && item.ClrFullNameType == typeof(byte).FullName).Count() == 0 ? false : true;

        /// <summary>
        /// Validates if column database type is <see cref="Byte"/> array
        /// </summary>
        /// <param name="database"><see cref="Database"/> instance</param>
        /// <param name="column"><see cref="Column"/> database</param>
        /// <returns>True if <see cref="Column"/> database type is <see cref="Byte"/> array, otherwise false</returns>
        public static bool ColumnIsByteArray(this Database database, Column column)
            => database.DatabaseTypeMaps.Where(item => item.DatabaseType == column.Type && item.ClrFullNameType == typeof(byte[]).FullName).Count() == 0 ? false : true;

        /// <summary>
        /// Validates if column database type is <see cref="DateTime"/>
        /// </summary>
        /// <param name="database"><see cref="Database"/> instance</param>
        /// <param name="column"><see cref="Column"/> database</param>
        /// <returns>True if <see cref="Column"/> database type is <see cref="DateTime"/>, otherwise false</returns>
        public static bool ColumnIsDateTime(this Database database, Column column)
            => database.DatabaseTypeMaps.Where(item => item.DatabaseType == column.Type && item.ClrFullNameType == typeof(DateTime).FullName).Count() == 0 ? false : true;

        /// <summary>
        /// Validates if column database type is <see cref="Decimal"/>
        /// </summary>
        /// <param name="database"><see cref="Database"/> instance</param>
        /// <param name="column"><see cref="Column"/> database</param>
        /// <returns>True if <see cref="Column"/> database type is <see cref="Decimal"/>, otherwise false</returns>
        public static bool ColumnIsDecimal(this Database database, Column column)
            => database.DatabaseTypeMaps.Where(item => item.DatabaseType == column.Type && item.ClrFullNameType == typeof(decimal).FullName).Count() == 0 ? false : true;

        /// <summary>
        /// Validates if column database type is <see cref="Double"/>
        /// </summary>
        /// <param name="database"><see cref="Database"/> instance</param>
        /// <param name="column"><see cref="Column"/> database</param>
        /// <returns>True if <see cref="Column"/> database type is <see cref="Double"/>, otherwise false</returns>
        public static bool ColumnIsDouble(this Database database, Column column)
            => database.DatabaseTypeMaps.Where(item => item.DatabaseType == column.Type && item.ClrFullNameType == typeof(double).FullName).Count() == 0 ? false : true;

        /// <summary>
        /// Validates if column database type is <see cref="Guid"/>
        /// </summary>
        /// <param name="database"><see cref="Database"/> instance</param>
        /// <param name="column"><see cref="Column"/> database</param>
        /// <returns>True if <see cref="Column"/> database type is <see cref="Guid"/>, otherwise false</returns>
        public static bool ColumnIsGuid(this Database database, Column column)
            => database.DatabaseTypeMaps.Where(item => item.DatabaseType == column.Type && item.ClrFullNameType == typeof(Guid).FullName).Count() == 0 ? false : true;

        /// <summary>
        /// Validates if column database type is <see cref="Int16"/>
        /// </summary>
        /// <param name="database"><see cref="Database"/> instance</param>
        /// <param name="column"><see cref="Column"/> database</param>
        /// <returns>True if <see cref="Column"/> database type is <see cref="Int16"/>, otherwise false</returns>
        public static bool ColumnIsInt16(this Database database, Column column)
            => database.DatabaseTypeMaps.Where(item => item.DatabaseType == column.Type && item.ClrFullNameType == typeof(short).FullName).Count() == 0 ? false : true;

        /// <summary>
        /// Validates if column database type is <see cref="Int32"/>
        /// </summary>
        /// <param name="database"><see cref="Database"/> instance</param>
        /// <param name="column"><see cref="Column"/> database</param>
        /// <returns>True if <see cref="Column"/> database type is <see cref="Int32"/>, otherwise false</returns>
        public static bool ColumnIsInt32(this Database database, Column column)
            => database.DatabaseTypeMaps.Where(item => item.DatabaseType == column.Type && item.ClrFullNameType == typeof(int).FullName).Count() == 0 ? false : true;

        /// <summary>
        /// Validates if column database type is <see cref="Int64"/>
        /// </summary>
        /// <param name="database"><see cref="Database"/> instance</param>
        /// <param name="column"><see cref="Column"/> database</param>
        /// <returns>True if <see cref="Column"/> database type is <see cref="Int64"/>, otherwise false</returns>
        public static bool ColumnIsInt64(this Database database, Column column)
            => database.DatabaseTypeMaps.Where(item => item.DatabaseType == column.Type && item.ClrFullNameType == typeof(long).FullName).Count() == 0 ? false : true;

        /// <summary>
        /// Validates if column database type is number
        /// </summary>
        /// <param name="database"><see cref="Database"/> instance</param>
        /// <param name="column"><see cref="Column"/> database</param>
        /// <returns>True if <see cref="Column"/> database type is number, otherwise false</returns>
        public static bool ColumnIsNumber(this Database database, Column column)
            => (new string[]
            {
                typeof(decimal).FullName,
                typeof(double).FullName,
                typeof(float).FullName,
                typeof(int).FullName,
                typeof(long).FullName,
                typeof(short).FullName
            }).Contains(database.DatabaseTypeMaps.FirstOrDefault(item => item.DatabaseType == column.Type)?.ClrFullNameType);

        /// <summary>
        /// Validates if column database type is <see cref="Single"/>
        /// </summary>
        /// <param name="database"><see cref="Database"/> instance</param>
        /// <param name="column"><see cref="Column"/> database</param>
        /// <returns>True if <see cref="Column"/> database type is <see cref="Single"/>, otherwise false</returns>
        public static bool ColumnIsSingle(this Database database, Column column)
            => database.DatabaseTypeMaps.Where(item => item.DatabaseType == column.Type && item.ClrFullNameType == typeof(float).FullName).Count() == 0 ? false : true;

        /// <summary>
        /// Validates if column database type is <see cref="String"/>
        /// </summary>
        /// <param name="database"><see cref="Database"/> instance</param>
        /// <param name="column"><see cref="Column"/> database</param>
        /// <returns>True if <see cref="Column"/> database type is <see cref="String"/>, otherwise false</returns>
        public static bool ColumnIsString(this Database database, Column column)
            => database.DatabaseTypeMaps.Where(item => item.DatabaseType == column.Type && item.ClrFullNameType == typeof(string).FullName).Count() == 0 ? false : true;

        /// <summary>
        /// Resolves a type for <see cref="Column"/> instance
        /// </summary>
        /// <param name="database"><see cref="Database"/> instance</param>
        /// <param name="column"><see cref="Column"/> database</param>
        /// <returns>A <see cref="DatabaseTypeMap"/> instance from database type maps collection in <see cref="Database"/> instance</returns>
        public static DatabaseTypeMap ResolveType(this Database database, Column column)
            => database.DatabaseTypeMaps.FirstOrDefault(item => item.DatabaseType == column.Type);

        /// <summary>
        /// Resolves a type for <see cref="Column"/> instance
        /// </summary>
        /// <param name="database"><see cref="Database"/> instance</param>
        /// <param name="type">Database type name</param>
        /// <returns></returns>
        public static DatabaseTypeMap ResolveType(this Database database, string type)
            => database.DatabaseTypeMaps.FirstOrDefault(item => item.DatabaseType == type);

        /// <summary>
        /// Gets all coincidences for CLR provided type
        /// </summary>
        /// <param name="database"><see cref="Database"/> instance</param>
        /// <param name="type"><see cref="Type"/> instance</param>
        /// <returns>A collection of matches for </returns>
        public static IEnumerable<DatabaseTypeMap> GetTypeMaps(this Database database, Type type)
            => database.DatabaseTypeMaps.Where(item => item.GetClrType() == type);
    }
}
