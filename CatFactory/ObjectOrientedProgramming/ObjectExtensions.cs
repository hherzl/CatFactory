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
        /// <returns></returns>
        public static ClassDefinition RefactClassDefinition(this object obj, string name = null, string ns = null)
        {
            var sourceType = obj.GetType();

            var classDefinition = new ClassDefinition
            {
                Name = string.IsNullOrEmpty(name) ? sourceType.Name : name,
                Namespace = string.IsNullOrEmpty(ns) ? string.Empty : ns
            };

            foreach (var property in sourceType.GetProperties().Where(item => item.CanRead))
            {
                var type = property.PropertyType.Name;

                classDefinition.AddAutomaticProperty(AccessModifier.Public, type, property.Name);
            }

            return classDefinition;
        }
    }
}
