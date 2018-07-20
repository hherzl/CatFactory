using System.Collections.Generic;
using System.Diagnostics;

namespace CatFactory.OOP
{
    [DebuggerDisplay("Namespace={Namespace}, Name={Name}")]
    public class ObjectDefinition : IObjectDefinition
    {
        public ObjectDefinition()
        {
            TypeManager.Register(this);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<string> m_namespaces;

        public List<string> Namespaces
        {
            get
            {
                return m_namespaces ?? (m_namespaces = new List<string>());
            }
            set
            {
                m_namespaces = value;
            }
        }

        public string Namespace { get; set; }

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

        public bool IsPartial { get; set; }

        public string Name { get; set; }

        public virtual string FullName
            => string.IsNullOrEmpty(Namespace) ? Name : string.Format("{0}.{1}", Namespace, Name);

        public virtual bool HasInheritance
            => false;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<MetadataAttribute> m_attributes;

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

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
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

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<PropertyDefinition> m_properties;

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

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<MethodDefinition> m_methods;

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

        public override bool Equals(object obj)
        {
            var cast = obj as ObjectDefinition;

            if (cast != null && FullName == cast.FullName)
            {
                return true;
            }

            return false;
        }

        public override int GetHashCode()
            => base.GetHashCode();
    }
}
