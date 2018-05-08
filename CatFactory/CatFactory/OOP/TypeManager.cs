using System.Collections.Generic;
using System.Linq;

namespace CatFactory.OOP
{
    public static class TypeManager
    {
        private static List<IObjectDefinition> ObjectDefinitions;

        static TypeManager()
        {
            ObjectDefinitions = new List<IObjectDefinition>();
        }

        public static void Register(IObjectDefinition objectDefinition)
        {
            if (!ObjectDefinitions.Contains(objectDefinition))
                ObjectDefinitions.Add(objectDefinition);
        }

        public static IObjectDefinition GetItemByFullName(string fullName)
            => ObjectDefinitions.FirstOrDefault(item => item.FullName == fullName);

        public static IEnumerable<IObjectDefinition> GetItemsByName(string name)
            => ObjectDefinitions.Where(item => item.FullName == name);
    }
}
