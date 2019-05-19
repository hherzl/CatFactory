using System.Diagnostics;

namespace CatFactory.ObjectOrientedProgramming
{
    /// <summary>
    /// Represents a constant
    /// </summary>
    [DebuggerDisplay("IsReadOnly = {IsReadOnly}, AccessModifier={AccessModifier}, Type={Type}, Name={Name}")]
    public class ConstantDefinition
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)] private Documentation m_documentation;

        /// <summary>
        /// Initializes a new instance of <see cref="ConstantDefinition"/> class
        /// </summary>
        public ConstantDefinition()
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="ConstantDefinition"/> class
        /// </summary>
        /// <param name="accessModifier">Access modifier</param>
        /// <param name="type">Type</param>
        /// <param name="name">Name</param>
        /// <param name="value">Value</param>
        public ConstantDefinition(AccessModifier accessModifier, string type, string name, object value)
        {
            AccessModifier = accessModifier;
            Type = type;
            Name = name;
            Value = value;
        }

        /// <summary>
        /// Initializes a new instance of <see cref="ConstantDefinition"/> class
        /// </summary>
        /// <param name="type">Type</param>
        /// <param name="name">Name</param>
        /// <param name="value">Value</param>
        public ConstantDefinition(string type, string name, object value)
        {
            Type = type;
            Name = name;
            Value = value;
        }

        /// <summary>
        /// Gets or sets the XML documentation comments for current constant definition
        /// </summary>
        public Documentation Documentation
        {
            get => m_documentation ?? (m_documentation = new Documentation());
            set => m_documentation = value;
        }

        /// <summary>
        /// Gets or sets the access modifier for current constant definition
        /// </summary>
        public AccessModifier AccessModifier { get; set; }

        /// <summary>
        /// Gets or sets the type for current constant definition
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the name for current constant definition
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the value for current constant definition
        /// </summary>
        public object Value { get; set; }
    }
}
