using System.Collections.Generic;

namespace CatFactory.ObjectOrientedProgramming
{
    /// <summary>
    /// 
    /// </summary>
    public interface IClassDefinition : IObjectDefinition
    {
        /// <summary>
        /// 
        /// </summary>
        bool IsStatic { get; set; }

        /// <summary>
        /// 
        /// </summary>
        bool IsPartial { get; set; }

        /// <summary>
        /// 
        /// </summary>
        List<GenericTypeDefinition> GenericTypes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        string BaseClass { get; set; }

        /// <summary>
        /// 
        /// </summary>
        List<string> Implements { get; set; }

        /// <summary>
        /// 
        /// </summary>
        bool HasInheritance { get; }

        /// <summary>
        /// 
        /// </summary>
        List<ConstantDefinition> Constants { get; set; }

        /// <summary>
        /// 
        /// </summary>
        ClassConstructorDefinition StaticConstructor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        FinalizerDefinition Finalizer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        List<ClassConstructorDefinition> Constructors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        List<IndexerDefinition> Indexers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        List<FieldDefinition> Fields { get; set; }

        /// <summary>
        /// 
        /// </summary>
        List<EventDefinition> Events { get; set; }

        /// <summary>
        /// 
        /// </summary>
        List<PropertyDefinition> Properties { get; set; }

        /// <summary>
        /// 
        /// </summary>
        List<MethodDefinition> Methods { get; set; }
    }
}
