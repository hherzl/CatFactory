using System.Diagnostics;

namespace CatFactory.ObjectRelationalMapping;

/// <summary>
/// Represents an extended property for a database object.
/// </summary>
[DebuggerDisplay("Name={Name}, Value={Value}")]
public class ExtendedProperty
{
    /// <summary>
    /// Creates a new instance of <see cref="ExtendedProperty"/> class.
    /// </summary>
    /// <param name="level0Type">Level 0 type</param>
    /// <param name="level0Name">Level 0 name</param>
    /// <param name="level1Type">Level 1 type</param>
    /// <param name="level1Name">Level 1 name</param>
    /// <param name="name">Extended property name</param>
    /// <returns>A new instance of <see cref="ExtendedProperty"/> for level 1.</returns>
    public static ExtendedProperty CreateLevel1(string level0Type, string level0Name, string level1Type, string level1Name, string name)
    {
        return new(name)
        {
            Level0Type = level0Type,
            Level0Name = level0Name,
            Level1Type = level1Type,
            Level1Name = level1Name
        };
    }

    /// <summary>
    /// Creates a new instance of <see cref="ExtendedProperty"/> class.
    /// </summary>
    /// <param name="level0Type">Level 0 type</param>
    /// <param name="level0Name">Level 0 name</param>
    /// <param name="level1Type">Level 1 type</param>
    /// <param name="level1Name">Level 1 name</param>
    /// <param name="name">Extended property name</param>
    /// <param name="value">Extended property value</param>
    /// <returns>A new instance of <see cref="ExtendedProperty"/> for level 1.</returns>
    public static ExtendedProperty CreateLevel1(string level0Type, string level0Name, string level1Type, string level1Name, string name, string value)
    {
        return new(name, value)
        {
            Level0Type = level0Type,
            Level0Name = level0Name,
            Level1Type = level1Type,
            Level1Name = level1Name
        };
    }

    /// <summary>
    /// Creates a new instance of <see cref="ExtendedProperty"/> class.
    /// </summary>
    /// <param name="level0Type">Level 0 type</param>
    /// <param name="level0Name">Level 0 name</param>
    /// <param name="level1Type">Level 1 type</param>
    /// <param name="level1Name">Level 1 name</param>
    /// <param name="level2Type">Level 2 type</param>
    /// <param name="level2Name">Level 2 name</param>
    /// <param name="name">Extended property name</param>
    /// <param name="value">Extended property value</param>
    /// <returns>A new instance of <see cref="ExtendedProperty"/> for level 2.</returns>
    public static ExtendedProperty CreateLevel2(string level0Type, string level0Name, string level1Type, string level1Name, string level2Type, string level2Name, string name, string value)
    {
        return new(name, value)
        {
            Level0Type = level0Type,
            Level0Name = level0Name,
            Level1Type = level1Type,
            Level1Name = level1Name,
            Level2Type = level2Type,
            Level2Name = level2Name
        };
    }

    /// <summary>
    /// Creates a new instance of <see cref="ExtendedProperty"/> class.
    /// </summary>
    /// <param name="level0Type">Level 0 type</param>
    /// <param name="level0Name">Level 0 name</param>
    /// <param name="level1Type">Level 1 type</param>
    /// <param name="level1Name">Level 1 name</param>
    /// <param name="level2Type">Level 2 type</param>
    /// <param name="level2Name">Level 2 name</param>
    /// <param name="name">Extended property name</param>
    /// <returns>A new instance of <see cref="ExtendedProperty"/> for level 2.</returns>
    public static ExtendedProperty CreateLevel2(string level0Type, string level0Name, string level1Type, string level1Name, string level2Type, string level2Name, string name)
    {
        return new(name)
        {
            Level0Type = level0Type,
            Level0Name = level0Name,
            Level1Type = level1Type,
            Level1Name = level1Name,
            Level2Type = level2Type,
            Level2Name = level2Name
        };
    }

    #region [ Constructors ]

    /// <summary>
    /// Initializes a new instance of <see cref="ExtendedProperty"/> class.
    /// </summary>
    public ExtendedProperty()
    {
    }

    /// <summary>
    /// Initializes a new instance of <see cref="ExtendedProperty"/> class.
    /// </summary>
    /// <param name="name">Name for extended property</param>
    public ExtendedProperty(string name)
    {
        Name = name;
    }

    /// <summary>
    /// Initializes a new instance of <see cref="ExtendedProperty"/> class.
    /// </summary>
    /// <param name="name">Name for extended property</param>
    /// <param name="value">Value for extended property</param>
    public ExtendedProperty(string name, string value)
    {
        Name = name;
        Value = value;
    }

    #endregion

    #region [ Properties ]

    /// <summary>
    /// Gets or sets the name for extended property
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the value for extended property
    /// </summary>
    public string Value { get; set; }

    /// <summary>
    /// Gets or sets the level 0 type
    /// </summary>
    public string Level0Type { get; set; }

    /// <summary>
    /// Gets or sets the level 0 name
    /// </summary>
    public string Level0Name { get; set; }

    /// <summary>
    /// Gets or sets the level 1 type
    /// </summary>
    public string Level1Type { get; set; }

    /// <summary>
    /// Gets or sets the level 1 name
    /// </summary>
    public string Level1Name { get; set; }

    /// <summary>
    /// Gets or sets the level 2 type
    /// </summary>
    public string Level2Type { get; set; }

    /// <summary>
    /// Gets or sets the level 2 name
    /// </summary>
    public string Level2Name { get; set; }

    #endregion
}
