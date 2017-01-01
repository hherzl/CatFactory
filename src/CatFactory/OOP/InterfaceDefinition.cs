using System;
using System.Collections.Generic;

namespace CatFactory.OOP
{
    public class InterfaceDefinition : ObjectDefinition, IInterfaceDefinition
    {
        public Boolean IsPartial { get; set; }

        private List<EventDefinition> m_events;

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
