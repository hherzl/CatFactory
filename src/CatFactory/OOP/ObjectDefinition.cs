using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace CatFactory.OOP
{
    [DebuggerDisplay("Namespace={Namespace}, Name={Name}")]
    public class ObjectDefinition : IObjectDefinition
    {
        public ObjectDefinition()
        {
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<String> m_namespaces;

        public List<String> Namespaces
        {
            get
            {
                return m_namespaces ?? (m_namespaces = new List<String>());
            }
            set
            {
                m_namespaces = value;
            }
        }

        public String Namespace { get; set; }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Documentation m_documentation;

        public Documentation Documentation
        {
            get
            {
                return m_documentation ?? (m_documentation = new Documentation());
            }
            set
            {
                m_documentation = value;
            }
        }

        public AccessModifier AccessModifier { get; set; }

        public Boolean IsPartial { get; set; }

        public String Name { get; set; }

        public virtual String FullName
            => String.IsNullOrEmpty(Namespace) ? Name : String.Format("{0}.{1}", Namespace, Name);

        public String BaseClass { get; set; }

        public Boolean HasInheritance
            => !String.IsNullOrEmpty(BaseClass) || Implements.Count > 0;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<String> m_implements;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<MetadataAttribute> m_attributes;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<EventDefinition> m_events;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<PropertyDefinition> m_properties;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<MethodDefinition> m_methods;

        public List<String> Implements
        {
            get
            {
                return m_implements ?? (m_implements = new List<String>());
            }
            set
            {
                m_implements = value;
            }
        }

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

        public List<PropertyDefinition> Properties
        {
            get
            {
                return m_properties ?? (m_properties = new List<PropertyDefinition>());
            }
            set
            {
                m_properties = value;
            }
        }

        public List<MethodDefinition> Methods
        {
            get
            {
                return m_methods ?? (m_methods = new List<MethodDefinition>());
            }
            set
            {
                m_methods = value;
            }
        }

        public override Boolean Equals(Object obj)
        {
            var cast = obj as ObjectDefinition;

            if (cast != null)
            {
                if (FullName == cast.FullName)
                {
                    return true;
                }
            }

            return false;
        }

        public override Int32 GetHashCode()
            => base.GetHashCode();
    }
}
