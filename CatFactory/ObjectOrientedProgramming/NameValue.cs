using System.Collections.Generic;
using System.Diagnostics;

namespace CatFactory.ObjectOrientedProgramming
{
    /// <summary>
    /// Represents a name and value value
    /// </summary>
    [DebuggerDisplay("Name={Name}, Value={Value}")]
    public class NameValue : INameValue
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Documentation m_documentation;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<MetadataAttribute> m_attributes;

        /// <summary>
        /// Initializes a new instance of <see cref="NameValue"/> class
        /// </summary>
        public NameValue()
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="NameValue"/> class
        /// </summary>
        /// <param name="name">Name</param>
        public NameValue(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Initializes a new instance of <see cref="NameValue"/> class
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="value">Value</param>
        public NameValue(string name, string value)
        {
            Name = name;
            Value = value;
        }

        /// <summary>
        /// Gets or sets the name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the value
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets the XML documentation comments
        /// </summary>
        public Documentation Documentation
        {
            get => m_documentation ??= new Documentation();
            set => m_documentation = value;
        }

        /// <summary>
        /// Gets or sets the metadata attributes
        /// </summary>
        public List<MetadataAttribute> Attributes
        {
            get => m_attributes ??= new List<MetadataAttribute>();
            set => m_attributes = value;
        }
    }
}
