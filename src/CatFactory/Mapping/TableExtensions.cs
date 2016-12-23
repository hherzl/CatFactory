using System.Collections.Generic;
using System.Linq;

namespace CatFactory.Mapping
{
    public static class TableExtensions
    {
        public static IEnumerable<Column> GetColumnsWithOutKey(this ITable table)
        {
            return table.PrimaryKey == null ? table.Columns : table.Columns.Where(item => !table.PrimaryKey.Key.Contains(item.Name));
        }

        public static IEnumerable<Column> GetColumnsWithOutIdentity(this ITable table)
        {
            return table.Identity == null ? table.Columns : table.Columns.Where(item => table.Identity.Name != item.Name);
        }
    }
}
