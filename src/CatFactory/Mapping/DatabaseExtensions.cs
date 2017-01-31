using System;
using System.Linq;

namespace CatFactory.Mapping
{
    public static class DatabaseExtensions
    {
        public static void AddPrimaryKeyToTables(this Database database)
        {
            foreach (var table in database.Tables)
            {
                if (table.PrimaryKey == null && table.Columns.Count > 0)
                {
                    table.PrimaryKey = new PrimaryKey(table.Columns[0].Name);
                }
            }
        }

        public static void AddColumnForAllTables(this Database database, Column column, params String[] exclusions)
        {
            foreach (var table in database.Tables)
            {
                if (exclusions != null && exclusions.Contains(table.FullName))
                {
                    continue;
                }

                if (!table.Columns.Contains(column))
                {
                    table.Columns.Add(column);
                }
            }
        }

        public static void LinkTables(this Database db)
        {
            foreach (var table in db.Tables)
            {
                foreach (var column in table.Columns)
                {
                    if (table.PrimaryKey != null && table.PrimaryKey.Key.Count == 1 && table.PrimaryKey.Key.Contains(column.Name))
                    {
                        continue;
                    }

                    foreach (var parentTable in db.Tables)
                    {
                        if (table.FullName == parentTable.FullName)
                        {
                            continue;
                        }

                        if (parentTable.PrimaryKey != null && parentTable.PrimaryKey.Key.Contains(column.Name))
                        {
                            table.ForeignKeys.Add(new ForeignKey(column.Name)
                            {
                                ConstraintName = String.Format("FK_{0}_{1}_{2}", table.Name, column.Name, parentTable.Name),
                                References = parentTable.FullName
                            });

                            if (!parentTable.Childs.Contains(table.FullName))
                            {
                                parentTable.Childs.Add(table.FullName);
                            }

                        }
                    }
                }
            }
        }
    }
}
