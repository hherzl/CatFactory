namespace CatFactory.Mapping
{
    public interface ITable : IDbObject
    {
        PrimaryKey PrimaryKey { get; set; }

        Identity Identity { get; set; }
    }
}
