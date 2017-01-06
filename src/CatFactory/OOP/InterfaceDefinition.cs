using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace CatFactory.OOP
{
    [DebuggerDisplay("Namespace={Namespace}, Name={Name}, Properties={Properties.Count}")]
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
