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

        private List<ClassConstructorDefinition> m_constructors;
        private List<EventDefinition> m_events;

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

        public List<EventDefinition> Events
        {
            get
            {
                return m_events ?? (m_events = new List<EventDefinition>());
            }
            set
            {
                m_events = value;
            }
        }
    }
}
