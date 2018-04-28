using System.Collections.Generic;

namespace CatFactory.OOP
{
    public interface IClassDefinition : IObjectDefinition
    {
        bool IsStatic { get; set; }

        bool IsPartial { get; set; }

        List<GenericTypeDefinition> GenericTypes { get; set; }

        string BaseClass { get; set; }

        List<string> Implements { get; set; }

        bool HasInheritance { get; }

        List<ConstantDefinition> Constants { get; set; }

        ClassConstructorDefinition StaticConstructor { get; set; }

        FinalizerDefinition Finalizer { get; set; }

        List<ClassConstructorDefinition> Constructors { get; set; }

        List<IndexerDefinition> Indexers { get; set; }

        List<FieldDefinition> Fields { get; set; }

        List<EventDefinition> Events { get; set; }

        List<PropertyDefinition> Properties { get; set; }

        List<MethodDefinition> Methods { get; set; }
    }
}
