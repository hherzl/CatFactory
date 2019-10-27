using System.Collections.Generic;
using System.Linq;

namespace CatFactory.ObjectRelationalMapping
{
    /// <summary>
    /// Contains extension methods for <see cref="Table"/> class
    /// </summary>
    public static class TableExtensions
    {
        /// <summary>
        /// Gets columns list from constraint
        /// </summary>
        /// <param name="table">Table instance</param>
        /// <param name="constraint">Constraint instance</param>
        /// <returns>A columns sequence from table</returns>
        public static IEnumerable<IColumn> GetColumnsFromConstraint(this ITable table, IConstraint constraint)
            => table.Columns.Where(item => constraint.Key.Contains(item.Name));

        /// <summary>
        /// Gets columns with no identity from table
        /// </summary>
        /// <param name="table">Table instance</param>
        /// <returns>A columns sequence from table</returns>
        public static IEnumerable<IColumn> GetColumnsWithNoIdentity(this ITable table)
            => table.Identity == null ? table.Columns : table.Columns.Where(item => table.Identity.Name != item.Name);

        /// <summary>
        /// Gets columns with no primary key from table
        /// </summary>
        /// <param name="table">Table instance</param>
        /// <returns>A columns sequence from table</returns>
        public static IEnumerable<IColumn> GetColumnsWithNoPrimaryKey(this ITable table)
            => table.PrimaryKey == null ? table.Columns : table.Columns.Where(item => !table.PrimaryKey.Key.Contains(item.Name));

        /// <summary>
        /// Gets identity column for table
        /// </summary>
        /// <param name="table">Table instance</param>
        /// <returns>A column from table</returns>
        public static IColumn GetIdentityColumn(this ITable table)
            => table.Identity == null ? null : table.Columns.FirstOrDefault(item => table.Identity.Name == item.Name);
    }
}
