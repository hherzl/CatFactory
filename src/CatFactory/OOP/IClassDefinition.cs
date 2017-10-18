using System.Collections.Generic;

namespace CatFactory.OOP
{
    public interface IClassDefinition : IObjectDefinition
    {
        bool IsStatic { get; set; }

        string GenericType { get; set; }

        string BaseClass { get; set; }

        List<string> WhereConstraints { get; set; }

        List<ConstantDefinition> Constants { get; set; }

        ClassConstructorDefinition StaticConstructor { get; set; }

        FinalizerDefinition Finalizer { get; set; }

        List<ClassConstructorDefinition> Constructors { get; set; }

        List<Indexer> Indexers { get; set; }

        List<FieldDefinition> Fields { get; set; }
    }
}
