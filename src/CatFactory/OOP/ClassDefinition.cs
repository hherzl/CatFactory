using System;
using System.Collections.Generic;

namespace CatFactory.OOP
{
    public class ClassDefinition : ObjectDefinition, IClassDefinition
    {
        public ClassDefinition()
        {
        }

        public AccessModifier AccessModifier { get; set; }

        public Boolean IsStatic { get; set; }

        public Boolean IsPartial { get; set; }

        private List<MetadataAttribute> m_attributes;
        private List<ClassConstructorDefinition> m_constructors;

        public List<MetadataAttribute> Attributes
        {
            get
            {
                return m_attributes ?? (m_attributes = new List<MetadataAttribute>());
            }
            set
            {
                m_attributes = value;
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
    }
}
