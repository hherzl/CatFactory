using System.Collections.Generic;
using System.Diagnostics;
using CatFactory.CodeFactory;

namespace CatFactory.ObjectOrientedProgramming
{
    /// <summary>
    /// Represents a definition for Property in Object Oriented Programming context
    /// </summary>
    [DebuggerDisplay("AccessModifier={AccessModifier}, Type={Type}, Name={Name}")]
    public class PropertyDefinition : IMemberDefinition
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Documentation m_documentation;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<MetadataAttribute> m_attributes;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<ILine> m_getBody;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<ILine> m_setBody;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<ILine> m_initBody;

        /// <summary>
        /// Initializes a new instance of <see cref="PropertyDefinition"/> class
        /// </summary>
        public PropertyDefinition()
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="PropertyDefinition"/> class
        /// </summary>
        /// <param name="type">Type</param>
        /// <param name="name">Name</param>
        /// <param name="attribs">Metadata attributes</param>
        public PropertyDefinition(string type, string name, params MetadataAttribute[] attribs)
        {
            Type = type;
            Name = name;
            Attributes.AddRange(attribs);
        }

        /// <summary>
        /// Initializes a new instance of <see cref="PropertyDefinition"/> class
        /// </summary>
        /// <param name="accessModifier">Access modifier</param>
        /// <param name="type">Type</param>
        /// <param name="name">Name</param>
        /// <param name="attribs">Metadata attributes</param>
        public PropertyDefinition(AccessModifier accessModifier, string type, string name, params MetadataAttribute[] attribs)
        {
            AccessModifier = accessModifier;
            Type = type;
            Name = name;
            Attributes.AddRange(attribs);
        }

        /// <summary>
        /// Gets or sets the XML documentation comments for current property definition
        /// </summary>
        public Documentation Documentation
        {
            get => m_documentation ??= new Documentation();
            set => m_documentation = value;
        }

        /// <summary>
        /// Indicates if current property definition is virtual
        /// </summary>
        public bool IsVirtual { get; set; }

        /// <summary>
        /// Indicates if current property definition is override
        /// </summary>
        public bool IsOverride { get; set; }

        /// <summary>
        /// Indicates if current property definition is automatic (with no get and set bodies)
        /// </summary>
        public bool IsAutomatic { get; set; }

        /// <summary>
        /// Indicates if current property definition is readonly
        /// </summary>
        public bool IsReadOnly { get; set; }

        /// <summary>
        /// Gets or sets the attributes for current property definition
        /// </summary>
        public List<MetadataAttribute> Attributes
        {
            get => m_attributes ??= new List<MetadataAttribute>();
            set => m_attributes = value;
        }

        /// <summary>
        /// Gets or sets the access modifier for current property definition
        /// </summary>
        public AccessModifier AccessModifier { get; set; }

        /// <summary>
        /// Gets or sets the type for current property definition
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the name for current property definition
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the get body for current property definition
        /// </summary>
        public List<ILine> GetBody
        {
            get => m_getBody ??= new List<ILine>();
            set => m_getBody = value;
        }

        /// <summary>
        /// Gets or sets the set body for current property definition
        /// </summary>
        public List<ILine> SetBody
        {
            get => m_setBody ??= new List<ILine>();
            set => m_setBody = value;
        }

        /// <summary>
        /// Gets or sets the set body for current property definition
        /// </summary>
        public List<ILine> InitBody
        {
            get => m_initBody ??= new List<ILine>();
            set => m_initBody = value;
        }

        /// <summary>
        /// Gets or sets the initialization value for current property definition
        /// </summary>
        public string InitializationValue { get; set; }

        /// <summary>
        /// Inidcates if current property is positional (declaration in record)
        /// </summary>
        public bool IsPositional { get; set; }
    }
}
