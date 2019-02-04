using System.Collections.Generic;
using System.Diagnostics;

namespace CatFactory.ObjectOrientedProgramming
{
    /// <summary>
    /// Represents a definition for Class in Object Oriented Programming context
    /// </summary>
    [DebuggerDisplay("AccessModifier={AccessModifier}, Namespace={Namespace}, Name={Name}")]
    public class ClassDefinition : ObjectDefinition, IClassDefinition
    {
        /// <summary>
        /// Initializes a new instance of <see cref="ClassDefinition"/> class
        /// </summary>
        public ClassDefinition()
            : base()
        {
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
            get
            {
                return m_implements ?? (m_implements = new List<string>());
            }
            set
            {
                m_implements = value;
            }
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
            get
            {
                return m_genericTypes ?? (m_genericTypes = new List<GenericTypeDefinition>());
            }
            set
            {
                m_genericTypes = value;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<ConstantDefinition> m_constants;

        /// <summary>
        /// Gets or sets the constants for current class definition
        /// </summary>
        public List<ConstantDefinition> Constants
        {
            get
            {
                return m_constants ?? (m_constants = new List<ConstantDefinition>());
            }
            set
            {
                m_constants = value;
            }
        }

        /// <summary>
        /// Gets or sets the static constructor for current class definition
        /// </summary>
        public ClassConstructorDefinition StaticConstructor { get; set; }

        /// <summary>
        /// Gets or sets the finalizer for current class definition
        /// </summary>
        public FinalizerDefinition Finalizer { get; set; }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<ClassConstructorDefinition> m_constructors;

        /// <summary>
        /// Gets or sets the constructors for current class definition
        /// </summary>
        public List<ClassConstructorDefinition> Constructors
        {
            get
            {
                return m_constructors ?? (m_constructors = new List<ClassConstructorDefinition>());
            }
            set
            {
                m_constructors = value;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<IndexerDefinition> m_indexers;

        /// <summary>
        /// Gets or sets the indexers for current class definition
        /// </summary>
        public List<IndexerDefinition> Indexers
        {
            get
            {
                return m_indexers ?? (m_indexers = new List<IndexerDefinition>());
            }
            set
            {
                m_indexers = value;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<FieldDefinition> m_fields;

        /// <summary>
        /// Gets or sets the fields for current class definition
        /// </summary>
        public List<FieldDefinition> Fields
        {
            get
            {
                return m_fields ?? (m_fields = new List<FieldDefinition>());
            }
            set
            {
                m_fields = value;
            }
        }
    }
}
