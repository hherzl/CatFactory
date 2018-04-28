namespace CatFactory
{
    public interface INamingService
    {
        string Singularize(string value);

        string Pluralize(string value);
    }
}
