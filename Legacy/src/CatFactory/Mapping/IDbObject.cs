namespace CatFactory.Mapping
{
    public interface IDbObject
    {
        string Schema { get; set; }

        string Name { get; set; }

        string FullName { get; }

        string Type { get; set; }
    }
}
