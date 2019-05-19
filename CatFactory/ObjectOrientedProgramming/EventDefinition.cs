using System.Diagnostics;

namespace CatFactory.ObjectOrientedProgramming
{
    /// <summary>
    /// Represents a definition for Event in Object Oriented Programming context
    /// </summary>
    [DebuggerDisplay("AccessModifier={AccessModifier}, Type={Type}, Name={Name}")]
    public class EventDefinition : IMemberDefinition
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Documentation m_documentation;

        /// <summary>
        /// Initializes a new instance of <see cref="EventDefinition"/> class
        /// </summary>
        public EventDefinition()
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="EventDefinition"/> class
        /// </summary>
        /// <param name="type">Type</param>
        /// <param name="name">Name</param>
        public EventDefinition(string type, string name)
        {
            Type = type;
            Name = name;
        }

        /// <summary>
        /// Initializes a new instance of <see cref="EventDefinition"/> class
        /// </summary>
        /// <param name="accessModifier">Access modifier</param>
        /// <param name="type">Type</param>
        /// <param name="name">Name</param>
        public EventDefinition(AccessModifier accessModifier, string type, string name)
        {
            AccessModifier = accessModifier;
            Type = type;
            Name = name;
        }

        /// <summary>
        /// Gets or sets the XML documentation comments for current event definition
        /// </summary>
        public Documentation Documentation
        {
            get => m_documentation ?? (m_documentation = new Documentation());
            set => m_documentation = value;
        }

        /// <summary>
        /// Gets or sets the access modifier for current event definition
        /// </summary>
        public AccessModifier AccessModifier { get; set; }

        /// <summary>
        /// Gets or sets the type for current event definition
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the name for current event definition
        /// </summary>
        public string Name { get; set; }
    }
}
