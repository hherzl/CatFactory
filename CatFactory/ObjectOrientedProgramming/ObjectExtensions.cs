using System.Linq;

namespace CatFactory.ObjectOrientedProgramming
{
    /// <summary>
    /// Provides extension methods for instances
    /// </summary>
    public static class ObjectExtensions
    {
        /// <summary>
        /// Creates a new <see cref="ClassDefinition"/> from instance
        /// </summary>
        /// <param name="obj">Instance of model</param>
        /// <param name="name">Name of <see cref="ClassDefinition"/></param>
        /// <param name="ns">Namespace of <see cref="ClassDefinition"/></param>
        /// <param name="convertOptions">Convert options</param>
        /// <returns></returns>
        public static ClassDefinition RefactClassDefinition(this object obj, string name = null, string ns = null, ConvertOptions convertOptions = null)
        {
            var sourceType = obj.GetType();

            var definition = new ClassDefinition
            {
                Name = string.IsNullOrEmpty(name) ? sourceType.Name : name,
                Namespace = string.IsNullOrEmpty(ns) ? string.Empty : ns
            };

            convertOptions ??= new();

            foreach (var property in sourceType.GetProperties().Where(item => item.CanRead))
            {
                var type = property.PropertyType.Name;

                if (convertOptions.ConvertPropertiesAsFields)
                {
                    definition.Fields.Add(new FieldDefinition(AccessModifier.Public, type, property.Name));
                }
                else if (convertOptions.UseAutomaticProperties)
                {
                    definition.AddAutomaticProperty(AccessModifier.Public, type, property.Name);
                }
                else
                {
                    definition.Properties.Add(new PropertyDefinition(AccessModifier.Public, type, property.Name));
                }
            }

            return definition;
        }

        /// <summary>
        /// Creates a new <see cref="RecordDefinition"/> from instance
        /// </summary>
        /// <param name="obj">Instance of model</param>
        /// <param name="name">Name of <see cref="RecordDefinition"/></param>
        /// <param name="ns">Namespace of <see cref="RecordDefinition"/></param>
        /// <param name="convertOptions">Convert options</param>
        /// <returns></returns>
        public static RecordDefinition RefactRecordDefinition(this object obj, string name = null, string ns = null, ConvertOptions convertOptions = null)
        {
            var sourceType = obj.GetType();

            var definition = new RecordDefinition
            {
                Name = string.IsNullOrEmpty(name) ? sourceType.Name : name,
                Namespace = string.IsNullOrEmpty(ns) ? string.Empty : ns
            };

            convertOptions ??= new();

            foreach (var property in sourceType.GetProperties().Where(item => item.CanRead))
            {
                var type = property.PropertyType.Name;

                if (convertOptions.ConvertPropertiesAsFields)
                {
                    definition.Fields.Add(new FieldDefinition(AccessModifier.Public, type, property.Name));
                }
                else if (convertOptions.UseAutomaticProperties)
                {
                    definition.AddAutomaticProperty(AccessModifier.Public, type, property.Name);
                }
                else
                {
                    definition.Properties.Add(new PropertyDefinition(AccessModifier.Public, type, property.Name));
                }
            }

            return definition;
        }

        /// <summary>
        /// Creates a new <see cref="InterfaceDefinition"/> from instance
        /// </summary>
        /// <param name="obj">Instance of model</param>
        /// <param name="name">Name of <see cref="InterfaceDefinition"/></param>
        /// <param name="ns">Namespace of <see cref="InterfaceDefinition"/></param>
        /// <param name="convertOptions">Convert options</param>
        /// <returns></returns>
        public static InterfaceDefinition RefactInterfaceDefinition(this object obj, string name = null, string ns = null, ConvertOptions convertOptions = null)
        {
            var sourceType = obj.GetType();

            var definition = new InterfaceDefinition
            {
                Name = string.IsNullOrEmpty(name) ? sourceType.Name : name,
                Namespace = string.IsNullOrEmpty(ns) ? string.Empty : ns
            };

            convertOptions ??= new();

            foreach (var property in sourceType.GetProperties().Where(item => item.CanRead))
            {
                var type = property.PropertyType.Name;

                definition.Properties.Add(new PropertyDefinition(AccessModifier.Public, type, property.Name));
            }

            return definition;
        }
    }
}
