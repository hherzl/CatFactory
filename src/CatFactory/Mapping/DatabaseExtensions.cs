using System.Linq;

namespace CatFactory.Mapping
{
    public static class DatabaseExtensions
    {
        public static void AddDbObjectsFromTables(this Database database)
        {
            foreach (var table in database.Tables)
            {
                database.DbObjects.Add(new DbObject { Schema = table.Schema, Name = table.Name, Type = "table" });
            }
        }

        public static void AddDbObjectsFromViews(this Database database)
        {
            foreach (var view in database.Views)
            {
                database.DbObjects.Add(new DbObject { Schema = view.Schema, Name = view.Name, Type = "view" });
            }
        }

        public static void AddColumnsForTables(this Database database, Column[] columns, params string[] exclusions)
        {
            foreach (var table in database.Tables)
            {
                if (exclusions != null && exclusions.Contains(table.FullName))
                {
                    continue;
                }

                foreach (var column in columns)
                {
                    if (!table.Columns.Contains(column))
                    {
                        table.Columns.Add(column);
                    }
                }
            }
        }

        public static void AddColumnForTables(this Database database, Column column, params string[] exclusions)
            => AddColumnsForTables(database, new Column[] { column }, exclusions);

        public static void SetPrimaryKeyToTables(this Database database, params string[] exclusions)
        {
            foreach (var table in database.Tables)
            {
                if (exclusions != null && exclusions.Contains(table.FullName))
                {
                    continue;
                }

                if (table.PrimaryKey == null && table.Columns.Count > 0)
                {
                    table.PrimaryKey = new PrimaryKey(table.Columns[0].Name);
                }
            }
        }

        public static void SetIdentityForTables(this Database database, params string[] exclusions)
        {
            foreach (var table in database.Tables)
            {
                if (exclusions != null && exclusions.Contains(table.FullName))
                {
                    continue;
                }

                if (table.Identity == null && table.Columns.Count > 0)
                {
                    table.Identity = new Identity(table.Columns[0].Name, 1, 1);
                }
            }
        }

        public static void LinkTables(this Database database)
        {
            foreach (var table in database.Tables)
            {
                foreach (var column in table.Columns)
                {
                    if (table.PrimaryKey != null && table.PrimaryKey.Key.Count == 1 && table.PrimaryKey.Key.Contains(column.Name))
                    {
                        continue;
                    }

                    foreach (var parentTable in database.Tables)
                    {
                        if (table.FullName == parentTable.FullName)
                        {
                            continue;
                        }

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
        }

        public static void AddRelation(this Database database, ITable target, string[] key, ITable source)
        {
            target.ForeignKeys.Add(new ForeignKey(key)
            {
                ConstraintName = database.NamingConvention.GetForeignKeyConstraintName(target, key, source),
                References = source.FullName,
                Child = target.FullName
            });
        }
    }
}
