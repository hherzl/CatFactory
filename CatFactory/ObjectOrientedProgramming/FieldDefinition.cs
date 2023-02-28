using System.Collections.Generic;
using System.Diagnostics;

namespace CatFactory.ObjectOrientedProgramming
{
    /// <summary>
    /// Represents a definition for Field in Object Oriented Programming context
    /// </summary>
    [DebuggerDisplay("IsReadOnly = {IsReadOnly}, AccessModifier={AccessModifier}, Type={Type}, Name={Name}")]
    public class FieldDefinition : IMemberDefinition
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Documentation m_documentation;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<MetadataAttribute> m_attributes;

        /// <summary>
        /// Initializes a new instance of <see cref="FieldDefinition"/> class
        /// </summary>
        public FieldDefinition()
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="FieldDefinition"/> class
        /// </summary>
        /// <param name="type">Type</param>
        /// <param name="name">Name</param>
        /// <param name="attribs">Metadata attributes</param>
        public FieldDefinition(string type, string name, params MetadataAttribute[] attribs)
        {
            Type = type;
            Name = name;
            Attributes.AddRange(attribs);
        }

        /// <summary>
        /// Initializes a new instance of <see cref="FieldDefinition"/> class
        /// </summary>
        /// <param name="accessModifier">Access modifier</param>
        /// <param name="type">Type</param>
        /// <param name="name">Name</param>
        /// <param name="attribs">Metadata attributes</param>
        public FieldDefinition(AccessModifier accessModifier, string type, string name, params MetadataAttribute[] attribs)
        {
            AccessModifier = accessModifier;
            Type = type;
            Name = name;
            Attributes.AddRange(attribs);
        }

        /// <summary>
        /// Gets or sets the XML documentation comments for current field definition
        /// </summary>
        public Documentation Documentation
        {
            get => m_documentation ??= new Documentation();
            set => m_documentation = value;
        }

        /// <summary>
        /// Gets or sets the attributes for current field definition
        /// </summary>
        public List<MetadataAttribute> Attributes
        {
            get => m_attributes ??= new List<MetadataAttribute>();
            set => m_attributes = value;
        }

        /// <summary>
        /// Indicates if current field definition is static
        /// </summary>
        public bool IsStatic { get; set; }

        /// <summary>
        /// Indicates if current field definition is readonly
        /// </summary>
        public bool IsReadOnly { get; set; }

        /// <summary>
        /// Gets or sets the access modifier for current field definition
        /// </summary>
        public AccessModifier AccessModifier { get; set; }

        /// <summary>
        /// Gets or sets the type for current field definition
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the name for current field definition
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the value for current field definition
        /// </summary>
        public string Value { get; set; }
    }
}
