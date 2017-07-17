using System;
using System.Collections.Generic;

namespace CatFactory.OOP
{
    public interface IClassDefinition : IObjectDefinition
    {
        Boolean IsStatic { get; set; }

        String BaseClass { get; set; }

        List<ConstantDefinition> Constants { get; set; }

        ClassConstructorDefinition StaticConstructor { get; set; }

        FinalizerDefinition Finalizer { get; set; }

        List<ClassConstructorDefinition> Constructors { get; set; }

        List<FieldDefinition> Fields { get; set; }
    }
}
