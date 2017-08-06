using System;
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

        public Boolean IsStatic { get; set; }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<ConstantDefinition> m_constants;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<ClassConstructorDefinition> m_constructors;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<FieldDefinition> m_fields;

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
