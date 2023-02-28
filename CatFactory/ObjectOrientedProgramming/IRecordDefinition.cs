using System.Collections.Generic;

namespace CatFactory.ObjectOrientedProgramming
{
    /// <summary>
    /// Represents the model for Record in Object Oriented Programming context
    /// </summary>
    public interface IRecordDefinition : IObjectDefinition
    {
        /// <summary>
        /// Indicates if record definition is abstract
        /// </summary>
        bool IsAbstract { get; set; }

        /// <summary>
        /// Indicates if record definition is partial
        /// </summary>
        bool IsPartial { get; set; }

        /// <summary>
        /// Gets or sets the generic types for record definition
        /// </summary>
        List<GenericTypeDefinition> GenericTypes { get; set; }

        /// <summary>
        /// Gets or sets the base record for record definition
        /// </summary>
        string BaseRecord { get; set; }

        /// <summary>
        /// Gets or sets the implements list (Interfaces) for record definition
        /// </summary>
        List<string> Implements { get; set; }

        /// <summary>
        /// Indicates if record definition has inheritance (Base record or implements)
        /// </summary>
        bool HasInheritance { get; }

        /// <summary>
        /// Gets or sets the constants for record definition
        /// </summary>
        List<ConstantDefinition> Constants { get; set; }

        /// <summary>
        /// Gets or sets the static constructor for record definition
        /// </summary>
        ClassConstructorDefinition StaticConstructor { get; set; }

        /// <summary>
        /// Gets or sets the finalizer for record definition
        /// </summary>
        FinalizerDefinition Finalizer { get; set; }

        /// <summary>
        /// Gets or sets the constructors for record definition
        /// </summary>
        List<ClassConstructorDefinition> Constructors { get; set; }

        /// <summary>
        /// Gets or sets the indexers for record definition
        /// </summary>
        List<IndexerDefinition> Indexers { get; set; }

        /// <summary>
        /// Gets or sets the fields for record definition
        /// </summary>
        List<FieldDefinition> Fields { get; set; }

        /// <summary>
        /// Gets or sets the events for record definition
        /// </summary>
        List<EventDefinition> Events { get; set; }

        /// <summary>
        /// Gets or sets the properties for record definition
        /// </summary>
        List<PropertyDefinition> Properties { get; set; }

        /// <summary>
        /// Gets or sets the methods for record definition
        /// </summary>
        List<MethodDefinition> Methods { get; set; }
    }
}
