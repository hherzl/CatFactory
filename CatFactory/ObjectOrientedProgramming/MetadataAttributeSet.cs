using System.Diagnostics;

namespace CatFactory.ObjectOrientedProgramming
{
    /// <summary>
    /// Represent a set for Metadata Attribute
    /// </summary>
    [DebuggerDisplay("Name={Name}, Value={Value}")]
    public class MetadataAttributeSet : INameValue
    {
        /// <summary>
        /// Initializes a new instance of <see cref="MetadataAttributeSet"/>
        /// </summary>
        public MetadataAttributeSet()
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="MetadataAttributeSet"/>
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="value">Value</param>
        public MetadataAttributeSet(string name, string value)
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
    }
}
