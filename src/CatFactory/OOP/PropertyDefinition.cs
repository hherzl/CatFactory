using System;
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

        public PropertyDefinition(String type, String name, params MetadataAttribute[] attribs)
        {
            IsAutomatic = true;
            Type = type;
            Name = name;
            Attributes.AddRange(attribs);
        }

        public PropertyDefinition(AccessModifier accessModifier, String type, String name, params MetadataAttribute[] attribs)
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

        public Boolean IsVirtual { get; set; }

        public Boolean IsOverride { get; set; }

        public Boolean IsAutomatic { get; set; }

        public Boolean IsReadOnly { get; set; }

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

        public String Type { get; set; }

        public String Name { get; set; }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<ILine> m_getBody;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<ILine> m_setBody;

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

        public String InitializationValue { get; set; }
    }
}
