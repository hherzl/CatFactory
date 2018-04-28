using System.Collections.Generic;
using System.Diagnostics;
using CatFactory.CodeFactory;

namespace CatFactory.OOP
{
    [DebuggerDisplay("AccessModifier={AccessModifier}, Type={Type}, Name={Name}")]
    public class PropertyDefinition : IMemberDefinition
    {
        public PropertyDefinition()
        {
            IsAutomatic = true;
        }

        public PropertyDefinition(string type, string name, params MetadataAttribute[] attribs)
        {
            IsAutomatic = true;
            Type = type;
            Name = name;
            Attributes.AddRange(attribs);
        }

        public PropertyDefinition(AccessModifier accessModifier, string type, string name, params MetadataAttribute[] attribs)
        {
            AccessModifier = accessModifier;
            Type = type;
            Name = name;
            Attributes.AddRange(attribs);
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

        public bool IsVirtual { get; set; }

        public bool IsOverride { get; set; }

        public bool IsAutomatic { get; set; }

        public bool IsReadOnly { get; set; }

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

        public string Type { get; set; }

        public string Name { get; set; }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<ILine> m_getBody;

        public List<ILine> GetBody
        {
            get
            {
                return m_getBody ?? (m_getBody = new List<ILine>());
            }
            set
            {
                m_getBody = value;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<ILine> m_setBody;

        public List<ILine> SetBody
        {
            get
            {
                return m_setBody ?? (m_setBody = new List<ILine>());
            }
            set
            {
                m_setBody = value;
            }
        }

        public string InitializationValue { get; set; }
    }
}
