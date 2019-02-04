using System.Diagnostics;

namespace CatFactory.ObjectOrientedProgramming
{
    /// <summary>
    /// Represents a definition for GenericType in Object Oriented Programming context
    /// </summary>
    [DebuggerDisplay("Name={Name}, Constraint={Constraint}")]
    public class GenericTypeDefinition
    {
        /// <summary>
        /// Initializes a new instance of <see cref="GenericTypeDefinition"/> class
        /// </summary>
        public GenericTypeDefinition()
        {
        }

        /// <summary>
        /// Gets or sets the name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the constraint
        /// </summary>
        public string Constraint { get; set; }
    }
}
