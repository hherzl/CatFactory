using System.Collections.Generic;
using System.Linq;

namespace CatFactory.OOP
{
    public static class TypeManager
    {
        private static HashSet<IObjectDefinition> ObjectDefinitions;

        static TypeManager()
        {
            ObjectDefinitions = new HashSet<IObjectDefinition>();
        }

        public static void Register(IObjectDefinition objectDefinition)
        {
            ObjectDefinitions.Add(objectDefinition);
        }

        public static IObjectDefinition GetItemByFullName(string fullName)
            => ObjectDefinitions.FirstOrDefault(item => item.FullName == fullName);

        public static IEnumerable<IObjectDefinition> GetItemsByName(string name)
            => ObjectDefinitions.Where(item => item.FullName == name);
    }
}
