using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace CatFactory.OOP
{
    [DebuggerDisplay("AccessModifier={AccessModifier}, Name={Name}")]
    public class EnumDefinition
    {
        public EnumDefinition()
        {
        }

        public EnumDefinition(String name, params MetadataAttribute[] attribs)
        {
            Name = name;
            Attributes.AddRange(attribs);
        }

        public EnumDefinition(AccessModifier accessModifier, String name, params MetadataAttribute[] attribs)
        {
            AccessModifier = accessModifier;
            Name = name;
            Attributes.AddRange(attribs);
        }

        private Documentation m_documentation;
        private List<MetadataAttribute> m_attributes;

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

        public String Name { get; set; }

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
