using System;
using System.Collections.Generic;
using CatFactory.CodeFactory;

namespace CatFactory.OOP
{
    public class MethodDefinition
    {
        public MethodDefinition(String type, String name)
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

        public ModifierAccess ModifierAccess { get; set; }

        public String Prefix { get; set; }

        public String Type { get; set; }

        public String Name { get; set; }

        private List<ParameterDefinition> m_parameters;

        public List<ParameterDefinition> Parameters
        {
            get
            {
                return m_parameters ?? (m_parameters = new List<ParameterDefinition>());
            }
            set
            {
                m_parameters = value;
            }
        }

        private List<CodeLine> m_lines;

        public List<CodeLine> Lines
        {
            get
            {
                return m_lines ?? (m_lines = new List<CodeLine>());
            }
            set
            {
                m_lines = value;
            }
        }
    }
}
