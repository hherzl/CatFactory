using System;
using System.Collections.Generic;

namespace CatFactory.OOP
{
    public class ClassDefinition : ObjectDefinition, IClassDefinition
    {
        public Boolean IsPartial { get; set; }

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
    }
}
