using System;
using System.Collections.Generic;
using System.Diagnostics;
using CatFactory.CodeFactory;

namespace CatFactory.OOP
{
    [DebuggerDisplay("AccessModifier={AccessModifier}, Type={Type}, Name={Name}")]
    public class PropertyDefinition
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
        }

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

        public Boolean IsAutomatic { get; set; }

        public Boolean IsReadOnly { get; set; }

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

        private List<CodeLine> m_getBody;
        private List<CodeLine> m_setBody;

        public List<CodeLine> GetBody
        {
            get
            {
                return m_getBody ?? (m_getBody = new List<CodeLine>());
            }
            set
            {
                m_getBody = value;
            }
        }

        public List<CodeLine> SetBody
        {
            get
            {
                return m_setBody ?? (m_setBody = new List<CodeLine>());
            }
            set
            {
                m_setBody = value;
            }
        }
    }
}
