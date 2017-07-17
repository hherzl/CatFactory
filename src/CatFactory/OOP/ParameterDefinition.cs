using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace CatFactory.OOP
{
    [DebuggerDisplay("Type={Type}, Name={Name}, DefaultValue={DefaultValue}")]
    public class ParameterDefinition : IMemberDefinition
    {
        public ParameterDefinition()
        {
        }

        public ParameterDefinition(String type, String name, params MetadataAttribute[] attributes)
        {
            Type = type;
            Name = name;
            Attributes.AddRange(attributes);
        }

        public ParameterDefinition(AccessModifier accessModifier, String type, String name, params MetadataAttribute[] attributes)
        {
            AccessModifier = accessModifier;
            Type = type;
            Name = name;
            Attributes.AddRange(attributes);
        }

        public ParameterDefinition(String type, String name, String defaultValue, params MetadataAttribute[] attributes)
        {
            Type = type;
            Name = name;
            DefaultValue = defaultValue;
            Attributes.AddRange(attributes);
        }

        public ParameterDefinition(AccessModifier accessModifier, String type, String name, String defaultValue, params MetadataAttribute[] attributes)
        {
            AccessModifier = accessModifier;
            Type = type;
            Name = name;
            DefaultValue = defaultValue;
            Attributes.AddRange(attributes);
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

        public AccessModifier AccessModifier { get; set; }

        public Boolean IsParams { get; set; }

        public String Type { get; set; }

        public String Name { get; set; }

        public String DefaultValue { get; set; }
    }
}
