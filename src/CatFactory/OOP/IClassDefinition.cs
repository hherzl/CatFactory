using System;
using System.Collections.Generic;

namespace CatFactory.OOP
{
    public interface IClassDefinition : IObjectDefinition
    {
        List<ClassConstructorDefinition> Constructors { get; set; }

        Boolean IsPartial { get; set; }
    }
}
