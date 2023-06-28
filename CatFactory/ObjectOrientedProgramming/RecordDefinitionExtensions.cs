namespace CatFactory.ObjectOrientedProgramming
{
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
        public static void AddAutomaticProperty(this RecordDefinition recordDefinition, string type, string name)
        {
            var property = new PropertyDefinition(AccessModifier.Public, type, name)
            {
                IsAutomatic = true
            };

            recordDefinition.Properties.Add(property);
        }

        /// <summary>
        /// Adds a new automatic property in record definition
        /// </summary>
        /// <param name="recordDefinition">Instance of <see cref="RecordDefinition"/> class</param>
        /// <param name="accessModifier">Access modifier for property</param>
        /// <param name="type">Type for property</param>
        /// <param name="name">Name for property</param>
        public static void AddAutomaticProperty(this RecordDefinition recordDefinition, AccessModifier accessModifier, string type, string name)
        {
            var property = new PropertyDefinition(accessModifier, type, name)
            {
                IsAutomatic = true
            };

            recordDefinition.Properties.Add(property);
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
                        IsReadOnly = field.IsReadOnly,
                        IsStatic = field.IsStatic,
                        Value = field.Value
                    });
                }
            }

            if (convertOptions.IncludeProperties)
            {
                foreach (var property in recordDefinition.Properties)
                {
                    classDefinition.Properties.Add(new PropertyDefinition(property.AccessModifier, property.Type, property.Name)
                    {
                        IsAutomatic = property.IsAutomatic,
                        IsPositional = property.IsPositional,
                        IsReadOnly = property.IsReadOnly,
                        IsVirtual = property.IsVirtual
                    });
                }
            }

            return classDefinition;
        }
    }
}
