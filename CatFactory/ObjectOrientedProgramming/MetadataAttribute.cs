using System.Collections.Generic;
using System.Diagnostics;

namespace CatFactory.ObjectOrientedProgramming
{
    /// <summary>
    /// Represents a definition for Metadata Attribute in Object Oriented Programming context
    /// </summary>
    [DebuggerDisplay("Name={Name}, Arguments={Arguments.Count}, Sets={Sets.Count}")]
    public class MetadataAttribute
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private List<string> m_arguments;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private List<MetadataAttributeSet> m_sets;

        /// <summary>
        /// Initializes a new instance of <see cref="MetadataAttribute"/> class
        /// </summary>
        public MetadataAttribute()
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="MetadataAttribute"/> class
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="arguments">Arguments</param>
        public MetadataAttribute(string name, params string[] arguments)
        {
            Name = name;
            Arguments.AddRange(arguments);
        }

        /// <summary>
        /// Gets or sets the name for current Metadata attribute
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the arguments for current Metadata attribute
        /// </summary>
        public List<string> Arguments
        {
            get => m_arguments ?? (m_arguments = new List<string>());
            set => m_arguments = value;
        }

        /// <summary>
        /// Gets or sets the sets (name and value) for current Metadata attribute
        /// </summary>
        public List<MetadataAttributeSet> Sets
        {
            get => m_sets ?? (m_sets = new List<MetadataAttributeSet>());
            set => m_sets = value;
        }

        /// <summary>
        /// Indicates if current Metadata attribute has arguments
        /// </summary>
        public bool HasArguments
            => Arguments.Count > 0;

        /// <summary>
        /// Indicates if current Metadata attribute has sets
        /// </summary>
        public bool HasSets
            => Sets.Count > 0;

        /// <summary>
        /// Indicates if current Metadata attribute has members (arguments or sets)
        /// </summary>
        public bool HasMembers
            => HasArguments || HasSets;
    }
}
