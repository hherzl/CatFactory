using System;
using System.Collections.Generic;

namespace CatFactory.OOP
{
    public interface IClassDefinition : IObjectDefinition
    {
        List<MetadataAttribute> Attributes { get; set; }

        List<ClassConstructorDefinition> Constructors { get; set; }

        Boolean IsPartial { get; set; }
    }
}
