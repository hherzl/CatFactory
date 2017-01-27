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

        public static void AddColumnForAllTables(this Database database, Column column)
        {
            foreach (var table in database.Tables)
            {
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
                    if (!table.PrimaryKey.Key.Contains(column.Name))
                    {
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
                                    References = parentTable.FullName
                                });
                            }
                        }
                    }
                }
            }
        }
    }
}
