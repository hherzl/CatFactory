using System.Collections.ObjectModel;
using System.Diagnostics;

namespace CatFactory.ObjectOrientedProgramming;

/// <summary>
/// Represents a definition for GenericType in Object Oriented Programming context
/// </summary>
[DebuggerDisplay("Name={Name}, Constraint={string.Join(',', Constraint)}")]
public class GenericTypeDefinition
{
    /// <summary>
    /// Initializes a new instance of <see cref="GenericTypeDefinition"/> class
    /// </summary>
    public GenericTypeDefinition()
    {
    }

    /// <summary>
    /// Initializes a new instance of <see cref="GenericTypeDefinition"/> class
    /// </summary>
    /// <param name="name">Name for generic type</param>
    /// <param name="constraints">Constraints for generic type</param>
    public GenericTypeDefinition(string name, params string[] constraints)
    {
        Name = name;
        Constraints = new Collection<string>(constraints);
    }

    /// <summary>
    /// Gets or sets the name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the constraint
    /// </summary>
    public Collection<string> Constraints { get; set; }
}
