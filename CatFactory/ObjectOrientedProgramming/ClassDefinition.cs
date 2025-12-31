using System.Collections.Generic;
using System.Diagnostics;

namespace CatFactory.ObjectOrientedProgramming;

/// <summary>
/// Represents a definition for Class in Object Oriented Programming context
/// </summary>
[DebuggerDisplay("AccessModifier={AccessModifier}, Namespace={Namespace}, Name={Name}")]
public class ClassDefinition : ObjectDefinition, IClassDefinition
{
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private List<ClassConstructorDefinition> m_constructors;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private List<IndexerDefinition> m_indexers;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private List<FieldDefinition> m_fields;

    /// <summary>
    /// Initializes a new instance of <see cref="ClassDefinition"/> class
    /// </summary>
    public ClassDefinition()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of <see cref="ClassDefinition"/> class
    /// </summary>
    public ClassDefinition(string name, bool isStatic = false, bool isAbstract = false)
        : base()
    {
        Name = name;
        IsStatic = isStatic;
        IsAbstract = isAbstract;
    }

    /// <summary>
    /// Indicates if current object definition is static
    /// </summary>
    public bool IsStatic { get; set; }

    /// <summary>
    /// Indicates if current object definition is abstract
    /// </summary>
    public bool IsAbstract { get; set; }

    /// <summary>
    /// Gets or sets the base class for current class definition
    /// </summary>
    public string BaseClass { get; set; }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private List<string> m_implements;

    /// <summary>
    /// Gets or sets the implements list (Interfaces) for current class definition
    /// </summary>
    public List<string> Implements
    {
        get => m_implements ??= [];
        set => m_implements = value;
    }

    /// <summary>
    /// Indicates if current object definition has inheritance (Base class or implements)
    /// </summary>
    public override bool HasInheritance
        => !string.IsNullOrEmpty(BaseClass) || Implements.Count > 0;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private List<GenericTypeDefinition> m_genericTypes;

    /// <summary>
    /// Gets or sets the generic types for current object definition
    /// </summary>
    public List<GenericTypeDefinition> GenericTypes
    {
        get => m_genericTypes ??= [];
        set => m_genericTypes = value;
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private List<ConstantDefinition> m_constants;

    /// <summary>
    /// Gets or sets the constants for current class definition
    /// </summary>
    public List<ConstantDefinition> Constants
    {
        get => m_constants ??= [];
        set => m_constants = value;
    }

    /// <summary>
    /// Gets or sets the static constructor for current class definition
    /// </summary>
    public ClassConstructorDefinition StaticConstructor { get; set; }

    /// <summary>
    /// Gets or sets the finalizer for current class definition
    /// </summary>
    public FinalizerDefinition Finalizer { get; set; }

    /// <summary>
    /// Gets or sets the constructors for current class definition
    /// </summary>
    public List<ClassConstructorDefinition> Constructors
    {
        get => m_constructors ??= [];
        set => m_constructors = value;
    }

    /// <summary>
    /// Gets or sets the indexers for current class definition
    /// </summary>
    public List<IndexerDefinition> Indexers
    {
        get => m_indexers ??= [];
        set => m_indexers = value;
    }

    /// <summary>
    /// Gets or sets the fields for current class definition
    /// </summary>
    public List<FieldDefinition> Fields
    {
        get => m_fields ??= [];
        set => m_fields = value;
    }
}
