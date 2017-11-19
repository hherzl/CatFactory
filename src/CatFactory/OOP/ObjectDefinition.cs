using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace CatFactory.OOP
{
    [DebuggerDisplay("Namespace={Namespace}, Name={Name}")]
    public class ObjectDefinition : IObjectDefinition, IEqualityComparer<ObjectDefinition>
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
            => Implements.Count > 0;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<string> m_implements;

        public List<string> Implements
        {
            get
            {
                return m_implements ?? (m_implements = new List<string>());
            }
            set
            {
                m_implements = value;
            }
        }

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
        private HashSet<EventDefinition> m_events;

        public HashSet<EventDefinition> Events
        {
            get
            {
                return m_events ?? (m_events = new HashSet<EventDefinition>());
            }
            set
            {
                m_events = value;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private HashSet<PropertyDefinition> m_properties;

        public HashSet<PropertyDefinition> Properties
        {
            get
            {
                return m_properties ?? (m_properties = new HashSet<PropertyDefinition>());
            }
            set
            {
                m_properties = value;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private HashSet<MethodDefinition> m_methods;

        public HashSet<MethodDefinition> Methods
        {
            get
            {
                return m_methods ?? (m_methods = new HashSet<MethodDefinition>());
            }
            set
            {
                m_methods = value;
            }
        }

        #region IEqualityComparer
        public bool Equals(ObjectDefinition x, ObjectDefinition y)
        {
            return x.FullName.Equals(y.FullName);
        }

        public int GetHashCode(ObjectDefinition obj)
        {
            return base.GetHashCode();
        }
        #endregion
    }
}
