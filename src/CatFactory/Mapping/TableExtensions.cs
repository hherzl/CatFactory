using System.Collections.Generic;
using System.Linq;

namespace CatFactory.Mapping
{
    public static class TableExtensions
    {
        public static IEnumerable<Column> GetColumnsWithOutKey(this ITable table)
            => table.PrimaryKey == null ? table.Columns : table.Columns.Where(item => !table.PrimaryKey.Key.Contains(item.Name));

        public static IEnumerable<Column> GetColumnsWithOutIdentity(this ITable table)
            => table.Identity == null ? table.Columns : table.Columns.Where(item => table.Identity.Name != item.Name);

        public static IEnumerable<Column> GetAddColumns(this Table table, Project project)
            => table.GetColumnsWithOutKey().Where(item => !project.AddExclusions.Contains(item.Name));

        public static IEnumerable<Column> GetUpdateColumns(this Table table, Project project)
            => table.GetColumnsWithOutKey().Where(item => !project.UpdateExclusions.Contains(item.Name));
    }
}
