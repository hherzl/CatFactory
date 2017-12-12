using System.Collections.Generic;
using System.Diagnostics;

namespace CatFactory.OOP
{
    [DebuggerDisplay("AccessModifier={AccessModifier}, Namespace={Namespace}, Name={Name}")]
    public class EnumDefinition
    {
        public EnumDefinition()
        {
        }

        public EnumDefinition(string name, params MetadataAttribute[] attribs)
        {
            Name = name;
            Attributes.AddRange(attribs);
        }

        public EnumDefinition(AccessModifier accessModifier, string name, params MetadataAttribute[] attribs)
        {
            AccessModifier = accessModifier;
            Name = name;
            Attributes.AddRange(attribs);
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

        public AccessModifier AccessModifier { get; set; }

        public string Namespace { get; set; }

        public string Name { get; set; }

        public virtual string FullName
            => string.IsNullOrEmpty(Namespace) ? Name : string.Format("{0}.{1}", Namespace, Name);

        public string BaseType { get; set; }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<INameValue> m_sets;

        public List<INameValue> Sets
        {
            get
            {
                return m_sets ?? (m_sets = new List<INameValue>());
            }
            set
            {
                m_sets = value;
            }
        }
    }
}
