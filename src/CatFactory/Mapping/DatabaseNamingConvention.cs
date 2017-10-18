namespace CatFactory.Mapping
{
    public class DatabaseNamingConvention : IDatabaseNamingConvention
    {
        public DatabaseNamingConvention()
        {
        }

        public virtual string ValidName(string name)
            => name;

        public virtual string GetObjectName(params string[] names)
            => string.Join(".", names);

        public virtual string GetParameterName(string name)
            => name;

        public virtual string GetPrimaryKeyConstraintName(ITable table, string[] key)
            => string.Join("_", "PK", table.Schema, table.Name);

        public virtual string GetForeignKeyConstraintName(ITable table, string[] key, ITable references)
            => string.Join("_", "FK", table.Schema, table.Name, string.Join("_", key), references.Schema, references.Name);

        public virtual string GetUniqueConstraintName(ITable table, string[] key)
            => string.Join("_", "U", table.Schema, table.Name, string.Join("_", key));
    }
}
