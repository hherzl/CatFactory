using System.Collections.Generic;

namespace CatFactory.OOP
{
    public interface IClassDefinition : IObjectDefinition
    {
        bool IsStatic { get; set; }

        List<GenericTypeDefinition> GenericTypes { get; set; }

        string BaseClass { get; set; }

        List<ConstantDefinition> Constants { get; set; }

        ClassConstructorDefinition StaticConstructor { get; set; }

        FinalizerDefinition Finalizer { get; set; }

        List<ClassConstructorDefinition> Constructors { get; set; }

        List<IndexerDefinition> Indexers { get; set; }

        List<FieldDefinition> Fields { get; set; }
    }
}
