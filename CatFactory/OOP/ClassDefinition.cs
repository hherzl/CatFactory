using System.Collections.Generic;
using System.Diagnostics;

namespace CatFactory.OOP
{
    /// <summary>
    /// 
    /// </summary>
    [DebuggerDisplay("AccessModifier={AccessModifier}, Namespace={Namespace}, Name={Name}")]
    public class ClassDefinition : ObjectDefinition, IClassDefinition
    {
        /// <summary>
        /// 
        /// </summary>
        public ClassDefinition()
            : base()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public bool IsStatic { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string BaseClass { get; set; }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<string> m_implements;

        /// <summary>
        /// 
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
        /// 
        /// </summary>
        public override bool HasInheritance
            => !string.IsNullOrEmpty(BaseClass) || Implements.Count > 0;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<GenericTypeDefinition> m_genericTypes;

        /// <summary>
        /// 
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
        /// 
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
        /// 
        /// </summary>
        public ClassConstructorDefinition StaticConstructor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public FinalizerDefinition Finalizer { get; set; }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<ClassConstructorDefinition> m_constructors;

        /// <summary>
        /// 
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
        /// 
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
        /// 
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
