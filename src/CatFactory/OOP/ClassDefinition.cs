using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace CatFactory.OOP
{
    [DebuggerDisplay("AccessModifier={AccessModifier}, Type={Type}, Name={Name}, Value={Value}")]
    public class ClassDefinition : ObjectDefinition, IClassDefinition
    {
        public ClassDefinition()
        {
        }

        public Boolean IsStatic { get; set; }

        private List<ConstantDefinition> m_constants;
        private List<ClassConstructorDefinition> m_constructors;
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
