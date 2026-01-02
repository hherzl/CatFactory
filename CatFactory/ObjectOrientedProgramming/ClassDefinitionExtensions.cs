namespace CatFactory.ObjectOrientedProgramming;

/// <summary>
/// Provides extension methods for class definitions
/// </summary>
public static class ClassDefinitionExtensions
{
    /// <summary>
    /// Adds a new automatic property in class definition
    /// </summary>
    /// <param name="classDefinition">Instance of <see cref="ClassDefinition"/> class</param>
    /// <param name="type">Type for property</param>
    /// <param name="name">Name for property</param>
    public static void AddAutomaticProp(this ClassDefinition classDefinition, string type, string name)
    {
        var prop = new PropertyDefinition(AccessModifier.Public, type, name)
        {
            IsAutomatic = true
        };

        classDefinition.Properties.Add(prop);
    }

    /// <summary>
    /// Adds a new automatic property in class definition
    /// </summary>
    /// <param name="classDefinition">Instance of <see cref="ClassDefinition"/> class</param>
    /// <param name="accessModifier">Access modifier for property</param>
    /// <param name="type">Type for property</param>
    /// <param name="name">Name for property</param>
    public static void AddAutomaticProp(this ClassDefinition classDefinition, AccessModifier accessModifier, string type, string name)
    {
        var property = new PropertyDefinition(accessModifier, type, name)
        {
            IsAutomatic = true
        };

        classDefinition.Properties.Add(property);
    }

    /// <summary>
    /// Creates a record definition from class definition
    /// </summary>
    /// <param name="classDefinition">Instance of <see cref="ClassDefinition"/> class</param>
    /// <param name="convertOptions">Instance of <see cref="ConvertOptions"/> record</param>
    /// <returns></returns>
    public static RecordDefinition ToRecordDefinition(this ClassDefinition classDefinition, ConvertOptions convertOptions = null)
    {
        var recordDefinition = new RecordDefinition
        {
            AccessModifier = classDefinition.AccessModifier,
            Name = classDefinition.Name
        };

        convertOptions ??= new();

        if (convertOptions.IncludeFields)
        {
            foreach (var field in classDefinition.Fields)
            {
                recordDefinition.Fields.Add(new(field.AccessModifier, field.Type, field.Name)
                {
                    IsReadonly = field.IsReadonly,
                    IsStatic = field.IsStatic,
                    Value = field.Value
                });
            }
        }

        if (convertOptions.IncludeProperties)
        {
            foreach (var prop in classDefinition.Properties)
            {
                recordDefinition.Properties.Add(new(prop.AccessModifier, prop.Type, prop.Name)
                {
                    IsAutomatic = prop.IsAutomatic,
                    IsPositional = prop.IsPositional,
                    IsReadOnly = prop.IsReadOnly,
                    IsVirtual = prop.IsVirtual
                });
            }
        }

        return recordDefinition;
    }
}
