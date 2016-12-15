using System;
using System.Collections.Generic;
using CatFactory.CodeFactory;

namespace CatFactory.OOP
{
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

        public Metadata Documentation { get; set; }

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
    }
}
