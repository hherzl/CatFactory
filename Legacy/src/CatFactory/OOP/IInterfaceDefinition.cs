using System.Collections.Generic;

namespace CatFactory.OOP
{
    public interface IInterfaceDefinition : IObjectDefinition
    {
        bool IsPartial { get; set; }

        List<GenericTypeDefinition> GenericTypes { get; set; }

        List<string> Implements { get; set; }

        bool HasInheritance { get; }

        List<EventDefinition> Events { get; set; }

        List<PropertyDefinition> Properties { get; set; }

        List<MethodDefinition> Methods { get; set; }
    }
}
