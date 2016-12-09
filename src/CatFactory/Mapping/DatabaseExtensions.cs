using System;

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
                    table.PrimaryKey = new PrimaryKey(new String[] { table.Columns[0].Name });
                }
            }
        }
    }
}
