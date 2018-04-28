using System.Collections.Generic;
using System.Diagnostics;

namespace CatFactory.OOP
{
    [DebuggerDisplay("Type={Type}, Name={Name}, DefaultValue={DefaultValue}")]
    public class ParameterDefinition
    {
        public ParameterDefinition()
        {
        }

        public ParameterDefinition(string type, string name, params MetadataAttribute[] attributes)
        {
            Type = type;
            Name = name;
            Attributes.AddRange(attributes);
        }

        public ParameterDefinition(string type, string name, string defaultValue, params MetadataAttribute[] attributes)
        {
            Type = type;
            Name = name;
            DefaultValue = defaultValue;
            Attributes.AddRange(attributes);
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

        public bool IsParams { get; set; }

        public string Type { get; set; }

        public string Name { get; set; }

        public string DefaultValue { get; set; }
    }
}
