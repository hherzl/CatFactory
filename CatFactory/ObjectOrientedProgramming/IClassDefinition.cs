using System.Collections.Generic;

namespace CatFactory.ObjectOrientedProgramming
{
    /// <summary>
    /// Represents the model for Class in Object Oriented Programming context
    /// </summary>
    public interface IClassDefinition : IObjectDefinition
    {
        /// <summary>
        /// Indicates if class definition is static
        /// </summary>
        bool IsStatic { get; set; }

        /// <summary>
        /// Indicates if class definition is abstract
        /// </summary>
        bool IsAbstract { get; set; }

        /// <summary>
        /// Indicates if class definition is partial
        /// </summary>
        bool IsPartial { get; set; }

        /// <summary>
        /// Gets or sets the generic types for class definition
        /// </summary>
        List<GenericTypeDefinition> GenericTypes { get; set; }

        /// <summary>
        /// Gets or sets the base class for class definition
        /// </summary>
        string BaseClass { get; set; }

        /// <summary>
        /// Gets or sets the implements list (Interfaces) for class definition
        /// </summary>
        List<string> Implements { get; set; }

        /// <summary>
        /// Indicates if class definition has inheritance (Base class or implements)
        /// </summary>
        bool HasInheritance { get; }

        /// <summary>
        /// Gets or sets the constants for class definition
        /// </summary>
        List<ConstantDefinition> Constants { get; set; }

        /// <summary>
        /// Gets or sets the static constructor for class definition
        /// </summary>
        ClassConstructorDefinition StaticConstructor { get; set; }

        /// <summary>
        /// Gets or sets the finalizer for class definition
        /// </summary>
        FinalizerDefinition Finalizer { get; set; }

        /// <summary>
        /// Gets or sets the constructors for class definition
        /// </summary>
        List<ClassConstructorDefinition> Constructors { get; set; }

        /// <summary>
        /// Gets or sets the indexers for class definition
        /// </summary>
        List<IndexerDefinition> Indexers { get; set; }

        /// <summary>
        /// Gets or sets the fields for class definition
        /// </summary>
        List<FieldDefinition> Fields { get; set; }

        /// <summary>
        /// Gets or sets the events for class definition
        /// </summary>
        List<EventDefinition> Events { get; set; }

        /// <summary>
        /// Gets or sets the properties for class definition
        /// </summary>
        List<PropertyDefinition> Properties { get; set; }

        /// <summary>
        /// Gets or sets the methods for class definition
        /// </summary>
        List<MethodDefinition> Methods { get; set; }
    }
}
