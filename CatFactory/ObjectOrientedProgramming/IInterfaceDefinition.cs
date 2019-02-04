using System.Collections.Generic;

namespace CatFactory.ObjectOrientedProgramming
{
    /// <summary>
    /// Represents the model for Interface in Object Oriented Programming context
    /// </summary>
    public interface IInterfaceDefinition : IObjectDefinition
    {
        /// <summary>
        /// Indicates if interface definition is partial
        /// </summary>
        bool IsPartial { get; set; }

        /// <summary>
        /// Gets or sets the generic types for interface definition
        /// </summary>
        List<GenericTypeDefinition> GenericTypes { get; set; }

        /// <summary>
        /// Gets or sets the implements list (Interfaces) for interface definition
        /// </summary>
        List<string> Implements { get; set; }

        /// <summary>
        /// Indicates if interface definition has inheritance (Implements)
        /// </summary>
        bool HasInheritance { get; }

        /// <summary>
        /// Gets or sets the events for interface definition
        /// </summary>
        List<EventDefinition> Events { get; set; }

        /// <summary>
        /// Gets or sets the properties for interface definition
        /// </summary>
        List<PropertyDefinition> Properties { get; set; }

        /// <summary>
        /// Gets or sets the methods for interface definition
        /// </summary>
        List<MethodDefinition> Methods { get; set; }
    }
}
