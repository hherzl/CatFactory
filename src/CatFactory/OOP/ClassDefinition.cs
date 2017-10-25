using System.Collections.Generic;
using System.Diagnostics;

namespace CatFactory.OOP
{
    [DebuggerDisplay("AccessModifier={AccessModifier}, Namespace={Namespace}, Name={Name}")]
    public class ClassDefinition : ObjectDefinition, IClassDefinition
    {
        public ClassDefinition()
            : base()
        {
        }

        public bool IsStatic { get; set; }

        public string BaseClass { get; set; }

        public override bool HasInheritance
            => !string.IsNullOrEmpty(BaseClass) || Implements.Count > 0;

        public string GenericType { get; set; }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<string> m_whereConstraints;

        public List<string> WhereConstraints
        {
            get
            {
                return m_whereConstraints ?? (m_whereConstraints = new List<string>());
            }
            set
            {
                m_whereConstraints = value;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<ConstantDefinition> m_constants;

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

        public ClassConstructorDefinition StaticConstructor { get; set; }

        public FinalizerDefinition Finalizer { get; set; }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<ClassConstructorDefinition> m_constructors;

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
