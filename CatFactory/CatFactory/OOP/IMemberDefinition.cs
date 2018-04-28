namespace CatFactory.OOP
{
    public interface IMemberDefinition
    {
        AccessModifier AccessModifier { get; set; }

        string Type { get; set; }

        string Name { get; set; }
    }
}
