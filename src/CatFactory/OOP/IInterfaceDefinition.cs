using System.Collections.Generic;

namespace CatFactory.OOP
{
    public interface IInterfaceDefinition : IObjectDefinition
    {
        List<GenericTypeDefinition> GenericTypes { get; set; }
    }
}
