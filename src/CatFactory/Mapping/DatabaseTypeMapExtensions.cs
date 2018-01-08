using System;
using System.Collections.Generic;
using System.Linq;

namespace CatFactory.Mapping
{
    public static class DatabaseTypeMapExtensions
    {
        public static DatabaseTypeMap ResolveType(this Database database, Column column)
            => database.Mappings.FirstOrDefault(item => item.DatabaseType == column.Type);

        public static DatabaseTypeMap ResolveType(this Database database, string type)
            => database.Mappings.FirstOrDefault(item => item.DatabaseType == type);

        public static IEnumerable<DatabaseTypeMap> GetTypeMaps(this Database database, Type type)
            => database.Mappings.Where(item => item.ClrType == type);
    }
}
