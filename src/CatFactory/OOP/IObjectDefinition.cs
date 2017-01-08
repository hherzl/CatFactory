using System;
using System.Collections.Generic;

namespace CatFactory.OOP
{
    public interface IObjectDefinition
    {
        List<String> Namespaces { get; set; }

        String Namespace { get; set; }

        Metadata Documentation { get; set; }

        AccessModifier AccessModifier { get; set; }

        String Name { get; set; }

        String BaseClass { get; set; }

        List<String> Implements { get; set; }

        List<FieldDefinition> Fields { get; set; }

        List<PropertyDefinition> Properties { get; set; }

        List<MethodDefinition> Methods { get; set; }

        Boolean HasInheritance { get; }
    }
}
