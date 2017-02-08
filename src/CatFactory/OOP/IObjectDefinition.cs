using System;
using System.Collections.Generic;

namespace CatFactory.OOP
{
    public interface IObjectDefinition
    {
        IDefinitionValidator DefinitionValidator { get; }

        List<String> Namespaces { get; set; }

        String Namespace { get; set; }

        Documentation Documentation { get; set; }

        List<MetadataAttribute> Attributes { get; set; }

        AccessModifier AccessModifier { get; set; }

        Boolean IsPartial { get; set; }

        String Name { get; set; }

        List<String> Implements { get; set; }

        Boolean HasInheritance { get; }

        List<EventDefinition> Events { get; set; }

        List<PropertyDefinition> Properties { get; set; }

        List<MethodDefinition> Methods { get; set; }
    }
}
