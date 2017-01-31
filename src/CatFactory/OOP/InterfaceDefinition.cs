using System.Diagnostics;

namespace CatFactory.OOP
{
    [DebuggerDisplay("Namespace={Namespace}, Name={Name}, Properties={Properties.Count}")]
    public class InterfaceDefinition : ObjectDefinition, IInterfaceDefinition
    {
        public InterfaceDefinition()
        {
        }
    }
}
