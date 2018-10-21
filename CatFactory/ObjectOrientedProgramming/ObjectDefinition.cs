using System.Collections.Generic;
using System.Diagnostics;

namespace CatFactory.ObjectOrientedProgramming
{
    /// <summary>
    /// 
    /// </summary>
    [DebuggerDisplay("Namespace={Namespace}, Name={Name}")]
    public class ObjectDefinition : IObjectDefinition
    {
        /// <summary>
        /// 
        /// </summary>
        public ObjectDefinition()
        {
            TypeManager.Register(this);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<string> m_namespaces;

        /// <summary>
        /// 
        /// </summary>
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

        /// <summary>
        /// 
        /// </summary>
        public string Namespace { get; set; }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Documentation m_documentation;

        /// <summary>
        /// 
        /// </summary>
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

        /// <summary>
        /// 
        /// </summary>
        public AccessModifier AccessModifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool IsPartial { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string FullName
            => string.IsNullOrEmpty(Namespace) ? Name : string.Format("{0}.{1}", Namespace, Name);

        /// <summary>
        /// 
        /// </summary>
        public virtual bool HasInheritance
            => false;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<MetadataAttribute> m_attributes;

        /// <summary>
        /// 
        /// </summary>
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

        /// <summary>
        /// 
        /// </summary>
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

        /// <summary>
        /// 
        /// </summary>
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

        /// <summary>
        /// 
        /// </summary>
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj is ObjectDefinition cast && FullName == cast.FullName)
                return true;

            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
            => base.GetHashCode();
    }
}
