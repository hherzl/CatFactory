namespace CatFactory.ObjectOrientedProgramming;

#pragma warning disable

public static class MethodDefinitionExtensions
{
    public static MethodDefinition IsStatic(this MethodDefinition definition, bool flag = true)
    {
        definition.IsStatic = flag;

        if (flag)
        {
            definition.IsVirtual = !flag;
            definition.IsOverride = !flag;
        }

        return definition;
    }

    public static MethodDefinition IsExtension(this MethodDefinition definition, bool flag = true)
    {
        definition.IsExtension = flag;
        definition.IsStatic = flag;

        if (flag)
        {
            definition.IsVirtual = !flag;
            definition.IsOverride = !flag;
        }

        return definition;
    }

    public static MethodDefinition IsAsync(this MethodDefinition definition, bool flag = true)
    {
        definition.IsAsync = flag;

        return definition;
    }

    public static MethodDefinition IsVirtual(this MethodDefinition definition, bool flag = true)
    {
        definition.IsVirtual = flag;
        definition.IsOverride = !flag;

        return definition;
    }

    public static MethodDefinition IsOverride(this MethodDefinition definition, bool flag = true)
    {
        definition.IsOverride = flag;
        definition.IsVirtual = !flag;

        return definition;
    }
}
