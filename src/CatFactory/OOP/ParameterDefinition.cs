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

        public Metadata Documentation { get; set; }

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
    }
}
