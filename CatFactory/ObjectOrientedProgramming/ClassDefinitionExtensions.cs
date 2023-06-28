namespace CatFactory.ObjectOrientedProgramming
{
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
        public static void AddAutomaticProperty(this ClassDefinition classDefinition, string type, string name)
        {
            var property = new PropertyDefinition(AccessModifier.Public, type, name)
            {
                IsAutomatic = true
            };

            classDefinition.Properties.Add(property);
        }

        /// <summary>
        /// Adds a new automatic property in class definition
        /// </summary>
        /// <param name="classDefinition">Instance of <see cref="ClassDefinition"/> class</param>
        /// <param name="accessModifier">Access modifier for property</param>
        /// <param name="type">Type for property</param>
        /// <param name="name">Name for property</param>
        public static void AddAutomaticProperty(this ClassDefinition classDefinition, AccessModifier accessModifier, string type, string name)
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
        /// <param name="convertOptions">Instance of <see cref="ConvertToRecordOptions"/> record</param>
        /// <returns></returns>
        public static RecordDefinition ToRecordDefinition(this ClassDefinition classDefinition, ConvertToRecordOptions convertOptions = null)
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
                    recordDefinition.Fields.Add(new FieldDefinition(field.AccessModifier, field.Type, field.Name)
                    {
                        IsReadOnly = field.IsReadOnly,
                        IsStatic = field.IsStatic,
                        Value = field.Value
                    });
                }
            }

            if (convertOptions.IncludeProperties)
            {
                foreach (var property in classDefinition.Properties)
                {
                    recordDefinition.Properties.Add(new PropertyDefinition(property.AccessModifier, property.Type, property.Name)
                    {
                        IsAutomatic = property.IsAutomatic,
                        IsPositional = property.IsPositional,
                        IsReadOnly = property.IsReadOnly,
                        IsVirtual = property.IsVirtual
                    });
                }
            }

            return recordDefinition;
        }
    }
}
