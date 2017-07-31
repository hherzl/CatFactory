using System;
using System.Collections.Generic;
using System.Linq;

namespace CatFactory.Mapping
{
    public static class TableExtensions
    {
        public static String GetFullColumnName(this ITable table, Column column)
            => String.Join(".", new String[] { table.Schema, table.Name, column.Name });

        public static Boolean HasDefaultSchema(this IDbObject table)
            => String.IsNullOrEmpty(table.Schema) || String.Compare(table.Schema, "dbo", true) == 0;

        public static IEnumerable<Column> GetColumnsWithOutKey(this ITable table)
            => table.PrimaryKey == null ? table.Columns : table.Columns.Where(item => !table.PrimaryKey.Key.Contains(item.Name));

        public static IEnumerable<Column> GetColumnsWithOutIdentity(this ITable table)
            => table.Identity == null ? table.Columns : table.Columns.Where(item => table.Identity.Name != item.Name);

        public static IEnumerable<Column> GetAddColumns(this ITable table, Project project)
            => table.GetColumnsWithOutIdentity().Where(item => !project.AddExclusions.Contains(item.Name));

        public static IEnumerable<Column> GetUpdateColumns(this Table table, Project project)
            => table.GetColumnsWithOutKey().Where(item => !project.UpdateExclusions.Contains(item.Name));
    }
}
