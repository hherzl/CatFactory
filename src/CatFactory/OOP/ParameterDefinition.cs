using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace CatFactory.OOP
{
    [DebuggerDisplay("Type={Type}, Name={Name}")]
    public class ParameterDefinition
    {
        public ParameterDefinition()
        {
        }

        public ParameterDefinition(String type, String name)
        {
            Type = type;
            Name = name;
        }

        public ParameterDefinition(AccessModifier accessModifier, String type, String name)
        {
            AccessModifier = accessModifier;
            Type = type;
            Name = name;
        }

        public ParameterDefinition(String type, String name, String defaultValue)
        {
            Type = type;
            Name = name;
            DefaultValue = defaultValue;
        }

        public ParameterDefinition(AccessModifier accessModifier, String type, String name, String defaultValue)
        {
            AccessModifier = accessModifier;
            Type = type;
            Name = name;
            DefaultValue = defaultValue;
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

        public Boolean IsParams { get; set; }

        public String Type { get; set; }

        public String Name { get; set; }

        public String DefaultValue { get; set; }
    }
}
