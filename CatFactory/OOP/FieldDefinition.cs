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

        public FieldDefinition(string type, string name, params MetadataAttribute[] attribs)
        {
            Type = type;
            Name = name;
            Attributes.AddRange(attribs);
        }

        public FieldDefinition(AccessModifier accessModifier, string type, string name, params MetadataAttribute[] attribs)
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

        public bool IsStatic { get; set; }

        public bool IsReadOnly { get; set; }

        public AccessModifier AccessModifier { get; set; }

        public string Type { get; set; }

        public string Name { get; set; }

        public string Value { get; set; }
    }
}
