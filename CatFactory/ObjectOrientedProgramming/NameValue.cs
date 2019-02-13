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

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Documentation m_documentation;

        /// <summary>
        /// Gets or sets the XML documentation comments
        /// </summary>
        public Documentation Documentation
        {
            get
            {
                return m_documentation ?? (m_documentation = new Documentation());
            }
            set
            {
                m_documentation = value;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<MetadataAttribute> m_attributes;

        /// <summary>
        /// Gets or sets the metadata attributes
        /// </summary>
        public List<MetadataAttribute> Attributes
        {
            get
            {
                return m_attributes ?? (m_attributes = new List<MetadataAttribute>());
            }
            set
            {
                m_attributes = value;
            }
        }
    }
}
