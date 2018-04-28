using System.Collections.Generic;
using System.Linq;

namespace CatFactory.Mapping
{
    public static class TableExtensions
    {
        public static IEnumerable<Column> GetColumnsWithNoPrimaryKey(this ITable table)
            => table.PrimaryKey == null ? table.Columns : table.Columns.Where(item => !table.PrimaryKey.Key.Contains(item.Name));

        public static IEnumerable<Column> GetColumnsWithNoIdentity(this ITable table)
            => table.Identity == null ? table.Columns : table.Columns.Where(item => table.Identity.Name != item.Name);

        public static Column GetIdentityColumn(this ITable table)
            => table.Identity == null ? null : table.Columns.FirstOrDefault(item => table.Identity.Name == item.Name);

        public static IEnumerable<Column> GetColumnsFromConstraint(this ITable table, IConstraint constraint)
            => table.Columns.Where(item => constraint.Key.Contains(item.Name));
    }
}
