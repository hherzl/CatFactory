using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace CatFactory.OOP
{
    [DebuggerDisplay("IsReadOnly = {IsReadOnly}, AccessModifier={AccessModifier}, Type={Type}, Name={Name}")]
    public class FieldDefinition : IMemberDefinition
    {
        public FieldDefinition()
        {
        }

        public FieldDefinition(String type, String name, params MetadataAttribute[] attribs)
        {
            Type = type;
            Name = name;
            Attributes.AddRange(attribs);
        }

        public FieldDefinition(AccessModifier accessModifier, String type, String name, params MetadataAttribute[] attribs)
        {
            AccessModifier = accessModifier;
            Type = type;
            Name = name;
            Attributes.AddRange(attribs);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Documentation m_documentation;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
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

        public Boolean IsStatic { get; set; }

        public Boolean IsReadOnly { get; set; }

        public AccessModifier AccessModifier { get; set; }

        public String Type { get; set; }

        public String Name { get; set; }

        public String Value { get; set; }
    }
}
