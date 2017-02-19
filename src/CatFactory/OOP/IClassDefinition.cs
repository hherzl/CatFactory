using System;
using System.Collections.Generic;

namespace CatFactory.OOP
{
    public interface IClassDefinition : IObjectDefinition
    {
        String BaseClass { get; set; }

        List<ConstantDefinition> Constants { get; set; }

        List<FieldDefinition> Fields { get; set; }

        List<ClassConstructorDefinition> Constructors { get; set; }
    }
}
