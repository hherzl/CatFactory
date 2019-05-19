using System.Collections.Generic;
using System.Diagnostics;

namespace CatFactory.ObjectOrientedProgramming
{
    /// <summary>
    /// Represents a definition for Enum in Object Oriented Programming context
    /// </summary>
    [DebuggerDisplay("AccessModifier={AccessModifier}, Namespace={Namespace}, Name={Name}")]
    public class EnumDefinition : ObjectDefinition, IEnumDefinition
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private List<NameValue> m_sets;

        /// <summary>
        /// Initializes a new instance of <see cref="EnumDefinition"/> class
        /// </summary>
        public EnumDefinition()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="EnumDefinition"/> class
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="attribs">Metadata attributes</param>
        public EnumDefinition(string name, params MetadataAttribute[] attribs)
            : base()
        {
            Name = name;
            Attributes.AddRange(attribs);
        }

        /// <summary>
        /// Initializes a new instance of <see cref="EnumDefinition"/> class
        /// </summary>
        /// <param name="accessModifier">Access modifier</param>
        /// <param name="name">Name</param>
        /// <param name="attribs">Metadata attributes</param>
        public EnumDefinition(AccessModifier accessModifier, string name, params MetadataAttribute[] attribs)
            : base()
        {
            AccessModifier = accessModifier;
            Name = name;
            Attributes.AddRange(attribs);
        }

        /// <summary>
        /// Gets or sets the base type for current enum definition
        /// </summary>
        public string BaseType { get; set; }

        /// <summary>
        /// Indicates if current object definition has inheritance (BaseType)
        /// </summary>
        public override bool HasInheritance
            => !string.IsNullOrEmpty(BaseType);

        /// <summary>
        /// Gets or sets the sets (name and value) for current enum definition
        /// </summary>
        public List<NameValue> Sets
        {
            get => m_sets ?? (m_sets = new List<NameValue>());
            set => m_sets = value;
        }
    }
}
