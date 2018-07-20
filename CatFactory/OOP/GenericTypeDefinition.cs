using System.Diagnostics;

namespace CatFactory.OOP
{
    [DebuggerDisplay("Name={Name}, Constraint={Constraint}")]
    public class GenericTypeDefinition
    {
        public GenericTypeDefinition()
        {
        }

        public string Name { get; set; }

        public string Constraint { get; set; }
    }
}
