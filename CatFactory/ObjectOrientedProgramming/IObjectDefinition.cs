using System.Collections.Generic;

namespace CatFactory.ObjectOrientedProgramming
{
    /// <summary>
    /// Represents the model for Object in Object Oriented Programming context
    /// </summary>
    public interface IObjectDefinition
    {
        /// <summary>
        /// Gets or sets the namespaces for object definition
        /// </summary>
        List<string> Namespaces { get; set; }

        /// <summary>
        /// Gets or sets the namespace for object definition
        /// </summary>
        string Namespace { get; set; }

        /// <summary>
        /// Gets or sets the XML documentation comments for object definition
        /// </summary>
        Documentation Documentation { get; set; }

        /// <summary>
        /// Gets or sets the metadata attributes for object definition
        /// </summary>
        List<MetadataAttribute> Attributes { get; set; }

        /// <summary>
        /// Gets or sets the access modifier for object definition
        /// </summary>
        AccessModifier AccessModifier { get; set; }

        /// <summary>
        /// Gets or sets the name for object definition
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Gets the full name (Namespace.Name) for object definition
        /// </summary>
        string FullName { get; }
    }
}
