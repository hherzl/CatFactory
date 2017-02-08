using System;

namespace CatFactory.Mapping
{
    public class DatabaseNamingConvention : IDatabaseNamingConvention
    {
        public DatabaseNamingConvention()
        {
        }

        public virtual String ValidName(String name)
        {
            return name;
        }

        public virtual String GetPrimaryKeyConstraintName(String table, String[] key)
        {
            return String.Format("pk_{0}_{1}", table, String.Join("_", key));
        }

        public virtual String GetForeignKeyConstraintName(String table, String[] key, String reference)
        {
            return String.Format("fk_{0}_{1}_{2}", table, String.Join("_", key), reference);
        }

        public virtual String GetUniqueConstraintName(String table, String[] key)
        {
            return String.Format("u_{0}_{1}_{2}", table, String.Join("_", key));
        }
    }
}
