using System.Collections.Generic;

namespace CatFactory.ObjectOrientedProgramming
{
    /// <summary>
    /// Represents the model for Enumeration in Object Oriented Programming context
    /// </summary>
    public interface IEnumDefinition : IObjectDefinition
    {
        /// <summary>
        /// Gets or sets the base type
        /// </summary>
        string BaseType { get; set; }

        /// <summary>
        /// Gets or sets the sets (name and value)
        /// </summary>
        List<NameValue> Sets { get; set; }
    }
}
