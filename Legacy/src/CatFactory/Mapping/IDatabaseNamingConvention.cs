namespace CatFactory.Mapping
{
    public interface IDatabaseNamingConvention : INamingConvention
    {
        string GetObjectName(params string[] names);

        string GetParameterName(string name);

        string GetPrimaryKeyConstraintName(ITable table, string[] key);

        string GetForeignKeyConstraintName(ITable table, string[] key, ITable references);

        string GetUniqueConstraintName(ITable table, string[] key);
    }
}
