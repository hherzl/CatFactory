using System.Collections.Generic;
using System.Linq;

namespace CatFactory.Mapping
{
    public static class ConstraintExtensions
    {
        public static IEnumerable<Column> GetColumns(this IConstraint constraint, ITable table)
        {
            return table.Columns.Where(item => constraint.Key.Contains(item.Name));
        }
    }
}
