namespace CatFactory.ObjectOrientedProgramming;

/// <summary>
/// Provides extension methods for record definitions
/// </summary>
public static class RecordDefinitionExtensions
{
    /// <summary>
    /// Adds a new automatic property in record definition
    /// </summary>
    /// <param name="recordDefinition">Instance of <see cref="RecordDefinition"/> class</param>
    /// <param name="type">Type for property</param>
    /// <param name="name">Name for property</param>
    public static void AddAutomaticProp(this RecordDefinition recordDefinition, string type, string name)
    {
        var prop = new PropertyDefinition(AccessModifier.Public, type, name)
        {
            IsAutomatic = true
        };

        recordDefinition.Properties.Add(prop);
    }

    /// <summary>
    /// Adds a new automatic property in record definition
    /// </summary>
    /// <param name="recordDefinition">Instance of <see cref="RecordDefinition"/> class</param>
    /// <param name="accessModifier">Access modifier for property</param>
    /// <param name="type">Type for property</param>
    /// <param name="name">Name for property</param>
    public static void AddAutomaticProp(this RecordDefinition recordDefinition, AccessModifier accessModifier, string type, string name)
    {
        var prop = new PropertyDefinition(accessModifier, type, name)
        {
            IsAutomatic = true
        };

        recordDefinition.Properties.Add(prop);
    }

    /// <summary>
    /// Creates a record definition from class definition
    /// </summary>
    /// <param name="recordDefinition">Instance of <see cref="RecordDefinition"/> class</param>
    /// <param name="convertOptions">Instance of <see cref="ConvertOptions"/> record</param>
    /// <returns></returns>
    public static ClassDefinition ToClassDefinition(this RecordDefinition recordDefinition, ConvertOptions convertOptions = null)
    {
        var classDefinition = new ClassDefinition
        {
            AccessModifier = recordDefinition.AccessModifier,
            Name = recordDefinition.Name
        };

        convertOptions ??= new();

        if (convertOptions.IncludeFields)
        {
            foreach (var field in recordDefinition.Fields)
            {
                classDefinition.Fields.Add(new FieldDefinition(field.AccessModifier, field.Type, field.Name)
                {
                    IsReadonly = field.IsReadonly,
                    IsStatic = field.IsStatic,
                    Value = field.Value
                });
            }
        }

        if (convertOptions.IncludeProperties)
        {
            foreach (var prop in recordDefinition.Properties)
            {
                classDefinition.Properties.Add(new PropertyDefinition(prop.AccessModifier, prop.Type, prop.Name)
                {
                    IsAutomatic = prop.IsAutomatic,
                    IsPositional = prop.IsPositional,
                    IsReadOnly = prop.IsReadOnly,
                    IsVirtual = prop.IsVirtual
                });
            }
        }

        return classDefinition;
    }
}
