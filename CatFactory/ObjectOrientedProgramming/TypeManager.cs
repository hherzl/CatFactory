using System.Collections.Generic;
using System.Linq;

namespace CatFactory.ObjectOrientedProgramming
{
    /// <summary>
    /// Manages all definitions created by CatFactory engine
    /// </summary>
    public static class TypeManager
    {
        static TypeManager()
        {
            ObjectDefinitions = new List<IObjectDefinition>();
        }

        /// <summary>
        /// Gets the object definitions
        /// </summary>
        public static List<IObjectDefinition> ObjectDefinitions { get; }

        /// <summary>
        /// Records an object definition in <see cref="TypeManager"/> catalog 
        /// </summary>
        /// <param name="objectDefinition">Instance of <see cref="ObjectDefinition"/> class</param>
        public static void Register(IObjectDefinition objectDefinition)
        {
            if (!ObjectDefinitions.Contains(objectDefinition))
                ObjectDefinitions.Add(objectDefinition);
        }

        /// <summary>
        /// Retrieves an object definition from <see cref="TypeManager"/> catalog
        /// </summary>
        /// <param name="fullName">Full name</param>
        /// <returns></returns>
        public static IObjectDefinition GetItemByFullName(string fullName)
            => ObjectDefinitions.FirstOrDefault(item => item.FullName == fullName);

        /// <summary>
        /// Retrieves object definitions from <see cref="TypeManager"/> catalog
        /// </summary>
        /// <param name="name">Name</param>
        /// <returns>A sequence of object definitions that match with name</returns>
        public static IEnumerable<IObjectDefinition> GetItemsByName(string name)
            => ObjectDefinitions.Where(item => item.FullName == name);
    }
}
