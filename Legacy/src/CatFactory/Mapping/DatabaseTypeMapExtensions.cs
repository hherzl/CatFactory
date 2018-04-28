using System;

namespace CatFactory.Mapping
{
    public static class DatabaseTypeMapExtensions
    {
        public static Type GetClrType(this DatabaseTypeMap dbTypeMap)
            => dbTypeMap.HasClrFullNameType ? Type.GetType(dbTypeMap.ClrFullNameType) : null;
    }
}
