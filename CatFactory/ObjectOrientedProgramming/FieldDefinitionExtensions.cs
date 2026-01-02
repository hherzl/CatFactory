namespace CatFactory.ObjectOrientedProgramming;

#pragma warning disable

public static class FieldDefinitionExtensions
{
    public static FieldDefinition IsStatic(this FieldDefinition definition, bool flag = true)
    {
        definition.IsStatic = flag;

        return definition;
    }

    public static FieldDefinition IsReadonly(this FieldDefinition definition, bool flag = true)
    {
        definition.IsReadonly = flag;

        return definition;
    }
}
