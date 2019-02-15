using System;
using System.Collections.Generic;
using System.Linq;

namespace CatFactory.ObjectRelationalMapping
{
    /// <summary>
    /// Contains extension methods for <see cref="Database"/> class
    /// </summary>
    public static class DatabaseExtensions
    {
        /// <summary>
        /// Adds all tables as database objects in database
        /// </summary>
        /// <param name="database"><see cref="Database"/> instance</param>
        /// <returns><see cref="Database"/> instance</returns>
        public static Database AddDbObjectsFromTables(this Database database)
        {
            foreach (var table in database.Tables)
                database.DbObjects.Add(new DbObject(table.Schema, table.Name) { Type = "table" });

            return database;
        }

        /// <summary>
        /// Adds all views as database objects in database
        /// </summary>
        /// <param name="database"><see cref="Database"/> instance</param>
        /// <returns><see cref="Database"/> instance</returns>
        public static Database AddDbObjectsFromViews(this Database database)
        {
            foreach (var view in database.Views)
                database.DbObjects.Add(new DbObject(view.Schema, view.Name) { Type = "view" });

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
        /// Validates if column database type is <see cref="bool"/>
        /// </summary>
        /// <param name="database"><see cref="Database"/> instance</param>
        /// <param name="column"><see cref="Column"/> database</param>
        /// <returns>True if <see cref="Column"/> database type is <see cref="bool"/>, otherwise false</returns>
        public static bool ColumnIsBoolean(this Database database, Column column)
            => database.DatabaseTypeMaps.Count(item => item.DatabaseType == column.Type && item.ClrFullNameType == typeof(bool).FullName) == 0 ? false : true;

        /// <summary>
        /// Validates if column database type is <see cref="byte"/>
        /// </summary>
        /// <param name="database"><see cref="Database"/> instance</param>
        /// <param name="column"><see cref="Column"/> database</param>
        /// <returns>True if <see cref="Column"/> database type is <see cref="byte"/>, otherwise false</returns>
        public static bool ColumnIsByte(this Database database, Column column)
            => database.DatabaseTypeMaps.Count(item => item.DatabaseType == column.Type && item.ClrFullNameType == typeof(byte).FullName) == 0 ? false : true;

        /// <summary>
        /// Validates if column database type is <see cref="byte"/> array
        /// </summary>
        /// <param name="database"><see cref="Database"/> instance</param>
        /// <param name="column"><see cref="Column"/> database</param>
        /// <returns>True if <see cref="Column"/> database type is <see cref="byte"/> array, otherwise false</returns>
        public static bool ColumnIsByteArray(this Database database, Column column)
            => database.DatabaseTypeMaps.Count(item => item.DatabaseType == column.Type && item.ClrFullNameType == typeof(byte[]).FullName) == 0 ? false : true;

        /// <summary>
        /// Validates if column database type is <see cref="DateTime"/>
        /// </summary>
        /// <param name="database"><see cref="Database"/> instance</param>
        /// <param name="column"><see cref="Column"/> database</param>
        /// <returns>True if <see cref="Column"/> database type is <see cref="DateTime"/>, otherwise false</returns>
        public static bool ColumnIsDateTime(this Database database, Column column)
            => database.DatabaseTypeMaps.Count(item => item.DatabaseType == column.Type && item.ClrFullNameType == typeof(DateTime).FullName) == 0 ? false : true;

        /// <summary>
        /// Validates if column database type is <see cref="decimal"/>
        /// </summary>
        /// <param name="database"><see cref="Database"/> instance</param>
        /// <param name="column"><see cref="Column"/> database</param>
        /// <returns>True if <see cref="Column"/> database type is <see cref="decimal"/>, otherwise false</returns>
        public static bool ColumnIsDecimal(this Database database, Column column)
            => database.DatabaseTypeMaps.Count(item => item.DatabaseType == column.Type && item.ClrFullNameType == typeof(decimal).FullName) == 0 ? false : true;

        /// <summary>
        /// Validates if column database type is <see cref="double"/>
        /// </summary>
        /// <param name="database"><see cref="Database"/> instance</param>
        /// <param name="column"><see cref="Column"/> database</param>
        /// <returns>True if <see cref="Column"/> database type is <see cref="double"/>, otherwise false</returns>
        public static bool ColumnIsDouble(this Database database, Column column)
            => database.DatabaseTypeMaps.Count(item => item.DatabaseType == column.Type && item.ClrFullNameType == typeof(double).FullName) == 0 ? false : true;

        /// <summary>
        /// Validates if column database type is <see cref="Guid"/>
        /// </summary>
        /// <param name="database"><see cref="Database"/> instance</param>
        /// <param name="column"><see cref="Column"/> database</param>
        /// <returns>True if <see cref="Column"/> database type is <see cref="Guid"/>, otherwise false</returns>
        public static bool ColumnIsGuid(this Database database, Column column)
            => database.DatabaseTypeMaps.Count(item => item.DatabaseType == column.Type && item.ClrFullNameType == typeof(Guid).FullName) == 0 ? false : true;

        /// <summary>
        /// Validates if column database type is <see cref="short"/>
        /// </summary>
        /// <param name="database"><see cref="Database"/> instance</param>
        /// <param name="column"><see cref="Column"/> database</param>
        /// <returns>True if <see cref="Column"/> database type is <see cref="short"/>, otherwise false</returns>
        public static bool ColumnIsInt16(this Database database, Column column)
            => database.DatabaseTypeMaps.Count(item => item.DatabaseType == column.Type && item.ClrFullNameType == typeof(short).FullName) == 0 ? false : true;

        /// <summary>
        /// Validates if column database type is <see cref="int"/>
        /// </summary>
        /// <param name="database"><see cref="Database"/> instance</param>
        /// <param name="column"><see cref="Column"/> database</param>
        /// <returns>True if <see cref="Column"/> database type is <see cref="int"/>, otherwise false</returns>
        public static bool ColumnIsInt32(this Database database, Column column)
            => database.DatabaseTypeMaps.Count(item => item.DatabaseType == column.Type && item.ClrFullNameType == typeof(int).FullName) == 0 ? false : true;

        /// <summary>
        /// Validates if column database type is <see cref="long"/>
        /// </summary>
        /// <param name="database"><see cref="Database"/> instance</param>
        /// <param name="column"><see cref="Column"/> database</param>
        /// <returns>True if <see cref="Column"/> database type is <see cref="long"/>, otherwise false</returns>
        public static bool ColumnIsInt64(this Database database, Column column)
            => database.DatabaseTypeMaps.Count(item => item.DatabaseType == column.Type && item.ClrFullNameType == typeof(long).FullName) == 0 ? false : true;

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
        /// Validates if column database type is <see cref="float"/>
        /// </summary>
        /// <param name="database"><see cref="Database"/> instance</param>
        /// <param name="column"><see cref="Column"/> database</param>
        /// <returns>True if <see cref="Column"/> database type is <see cref="float"/>, otherwise false</returns>
        public static bool ColumnIsSingle(this Database database, Column column)
            => database.DatabaseTypeMaps.Count(item => item.DatabaseType == column.Type && item.ClrFullNameType == typeof(float).FullName) == 0 ? false : true;

        /// <summary>
        /// Validates if column database type is <see cref="string"/>
        /// </summary>
        /// <param name="database"><see cref="Database"/> instance</param>
        /// <param name="column"><see cref="Column"/> database</param>
        /// <returns>True if <see cref="Column"/> database type is <see cref="string"/>, otherwise false</returns>
        public static bool ColumnIsString(this Database database, Column column)
            => database.DatabaseTypeMaps.Count(item => item.DatabaseType == column.Type && item.ClrFullNameType == typeof(string).FullName) == 0 ? false : true;

        /// <summary>
        /// Gets all coincidences for CLR provided type
        /// </summary>
        /// <param name="database"><see cref="Database"/> instance</param>
        /// <param name="type"><see cref="Type"/> instance</param>
        /// <returns>A collection of matches for CLR type</returns>
        public static IEnumerable<DatabaseTypeMap> GetDatabaseTypeMaps(this Database database, Type type)
            => database.DatabaseTypeMaps.Where(item => item.GetClrType() == type);

        /// <summary>
        /// Validates if a database object has the default schema
        /// </summary>
        /// <param name="database"><see cref="Database"/> instance</param>
        /// <param name="dbObj"><see cref="IDbObject"/> instance</param>
        /// <returns>True if <see cref="IDbObject"/> has database's default schema, otherwise false</returns>
        public static bool HasDefaultSchema(this Database database, IDbObject dbObj)
            => string.IsNullOrEmpty(dbObj.Schema) || string.Compare(dbObj.Schema, database.DefaultSchema, true) == 0;

        /// <summary>
        /// Validates if <see cref="Table"/> instance has a <see cref="Guid"/> as <see cref="PrimaryKey"/>
        /// </summary>
        /// <param name="database"><see cref="Database"/> instance</param>
        /// <param name="table"><see cref="Table"/> instance</param>
        /// <returns>True if <see cref="Table"/> instance has <see cref="PrimaryKey"/>, otherwise false</returns>
        public static bool PrimaryKeyIsGuid(this Database database, ITable table)
            => table?.PrimaryKey?.Key?.Count == 1 && database.ColumnIsGuid(table.GetColumnsFromConstraint(table.PrimaryKey).First()) ? true : false;

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
                    if (table.PrimaryKey?.Key?.Count == 1 && table.PrimaryKey.Key.Contains(column.Name))
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
        /// Sets identity for tables in <see cref="Database"/> instance
        /// </summary>
        /// <param name="database"><see cref="Database"/> instance</param>
        /// <param name="seed">Seed for identity</param>
        /// <param name="increment">Increment for identity</param>
        /// <param name="exclusions">Exclusions for tables in <see cref="Database"/> instance</param>
        /// <returns><see cref="Database"/> instance</returns>
        public static Database SetIdentityForTables(this Database database, int seed = 1, int increment = 1, params string[] exclusions)
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
        public static Database SetPrimaryKeyForTables(this Database database, params string[] exclusions)
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
