using System.Collections.Generic;
using System.Diagnostics;

namespace CatFactory.ObjectOrientedProgramming
{
    /// <summary>
    /// Represents a definition for record in Object Oriented Programming context
    /// </summary>
    [DebuggerDisplay("AccessModifier={AccessModifier}, Namespace={Namespace}, Name={Name}")]
    public class RecordDefinition : ObjectDefinition, IRecordDefinition
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<ClassConstructorDefinition> m_constructors;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<IndexerDefinition> m_indexers;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<FieldDefinition> m_fields;

        /// <summary>
        /// Initializes a new instance of <see cref="RecordDefinition"/> class
        /// </summary>
        public RecordDefinition()
            : base()
        {
        }

        /// <summary>
        /// Indicates if current record definition is abstract
        /// </summary>
        public bool IsAbstract { get; set; }

        /// <summary>
        /// Indicates if current record definition is struct
        /// </summary>
        public bool IsStruct { get; set; }

        /// <summary>
        /// Gets or sets the base record for current record definition
        /// </summary>
        public string BaseRecord { get; set; }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<string> m_implements;

        /// <summary>
        /// Gets or sets the implements list (Interfaces) for current record definition
        /// </summary>
        public List<string> Implements
        {
            get => m_implements ??= new List<string>();
            set => m_implements = value;
        }

        /// <summary>
        /// Indicates if current object definition has inheritance (Base record or implements)
        /// </summary>
        public override bool HasInheritance
            => !string.IsNullOrEmpty(BaseRecord) || Implements.Count > 0;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<GenericTypeDefinition> m_genericTypes;

        /// <summary>
        /// Gets or sets the generic types for current object definition
        /// </summary>
        public List<GenericTypeDefinition> GenericTypes
        {
            get => m_genericTypes ??= new List<GenericTypeDefinition>();
            set => m_genericTypes = value;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<ConstantDefinition> m_constants;

        /// <summary>
        /// Gets or sets the constants for current record definition
        /// </summary>
        public List<ConstantDefinition> Constants
        {
            get => m_constants ??= new List<ConstantDefinition>();
            set => m_constants = value;
        }

        /// <summary>
        /// Gets or sets the static constructor for current record definition
        /// </summary>
        public ClassConstructorDefinition StaticConstructor { get; set; }

        /// <summary>
        /// Gets or sets the finalizer for current record definition
        /// </summary>
        public FinalizerDefinition Finalizer { get; set; }

        /// <summary>
        /// Gets or sets the constructors for current record definition
        /// </summary>
        public List<ClassConstructorDefinition> Constructors
        {
            get => m_constructors ??= new List<ClassConstructorDefinition>();
            set => m_constructors = value;
        }

        /// <summary>
        /// Gets or sets the indexers for current record definition
        /// </summary>
        public List<IndexerDefinition> Indexers
        {
            get => m_indexers ??= new List<IndexerDefinition>();
            set => m_indexers = value;
        }

        /// <summary>
        /// Gets or sets the fields for current record definition
        /// </summary>
        public List<FieldDefinition> Fields
        {
            get => m_fields ??= new List<FieldDefinition>();
            set => m_fields = value;
        }
    }
}
