using System.Collections.Generic;
using System.Diagnostics;

namespace CatFactory.ObjectOrientedProgramming
{
    /// <summary>
    /// Represents a definition for Parameter in Object Oriented Programming context
    /// </summary>
    [DebuggerDisplay("Type={Type}, Name={Name}, DefaultValue={DefaultValue}")]
    public class ParameterDefinition
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Documentation m_documentation;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private List<MetadataAttribute> m_attributes;

        /// <summary>
        /// Initializes a new instance of <see cref="ParameterDefinition"/> class
        /// </summary>
        public ParameterDefinition()
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="ParameterDefinition"/> class
        /// </summary>
        /// <param name="type">Type</param>
        /// <param name="name">Name</param>
        /// <param name="attributes">Metadata attributes</param>
        public ParameterDefinition(string type, string name, params MetadataAttribute[] attributes)
        {
            Type = type;
            Name = name;
            Attributes.AddRange(attributes);
        }

        /// <summary>
        /// Initializes a new instance of <see cref="ParameterDefinition"/> class
        /// </summary>
        /// <param name="type">Type</param>
        /// <param name="name">Name</param>
        /// <param name="defaultValue">Default value</param>
        /// <param name="attributes">Metadata attributes</param>
        public ParameterDefinition(string type, string name, string defaultValue, params MetadataAttribute[] attributes)
        {
            Type = type;
            Name = name;
            DefaultValue = defaultValue;
            Attributes.AddRange(attributes);
        }

        /// <summary>
        /// Gets or sets the XML documentation comments for current parameter definition
        /// </summary>
        public Documentation Documentation
        {
            get => m_documentation ?? (m_documentation = new Documentation());
            set => m_documentation = value;
        }

        /// <summary>
        /// Gets or sets the attributes for current parameter definition
        /// </summary>
        public List<MetadataAttribute> Attributes
        {
            get => m_attributes ?? (m_attributes = new List<MetadataAttribute>());
            set => m_attributes = value;
        }

        /// <summary>
        /// Indicates if current parameter definition is params
        /// </summary>
        public bool IsParams { get; set; }

        /// <summary>
        /// Gets or sets the type for current parameter definition
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the name for current parameter definition
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the default value for current parameter definition
        /// </summary>
        public string DefaultValue { get; set; }
    }
}
