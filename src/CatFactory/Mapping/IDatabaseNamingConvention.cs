using System;

namespace CatFactory.Mapping
{
    public interface IDatabaseNamingConvention : INamingConvention
    {
        String GetPrimaryKeyConstraintName(String table, String[] key);

        String GetForeignKeyConstraintName(String table, String[] key, String reference);

        String GetUniqueConstraintName(String table, String[] key);
    }
}
