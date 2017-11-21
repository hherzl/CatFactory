﻿using System.Collections.Generic;

namespace CatFactory.OOP
{
    public interface IObjectDefinition
    {
        List<string> Namespaces { get; set; }

        string Namespace { get; set; }

        Documentation Documentation { get; set; }

        List<MetadataAttribute> Attributes { get; set; }

        AccessModifier AccessModifier { get; set; }

        bool IsPartial { get; set; }

        string Name { get; set; }

        string FullName { get; }

        List<string> Implements { get; set; }

        bool HasInheritance { get; }

        HashSet<EventDefinition> Events { get; set; }

        HashSet<PropertyDefinition> Properties { get; set; }

        HashSet<MethodDefinition> Methods { get; set; }
    }
}
