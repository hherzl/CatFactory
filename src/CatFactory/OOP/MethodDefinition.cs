using System;
using System.Collections.Generic;
using System.Diagnostics;
using CatFactory.CodeFactory;

namespace CatFactory.OOP
{
    [DebuggerDisplay("AccessModifier={AccessModifier}, Type={Type}, Name={Name}, Parameters={Parameters.Count}")]
    public class MethodDefinition
    {
        public MethodDefinition()
        {
        }

        public MethodDefinition(String type, String name, params ParameterDefinition[] parameters)
        {
            Type = type;
            Name = name;
            Parameters.AddRange(parameters);
        }

        public MethodDefinition(String type, String name, params CodeLine[] lines)
        {
            Type = type;
            Name = name;
            Lines.AddRange(lines);
        }

        public MethodDefinition(AccessModifier accessModifier, String type, String name, params ParameterDefinition[] parameters)
        {
            AccessModifier = accessModifier;
            Type = type;
            Name = name;
            Parameters.AddRange(parameters);
        }

        public MethodDefinition(AccessModifier accessModifier, String type, String name, params CodeLine[] lines)
        {
            AccessModifier = accessModifier;
            Type = type;
            Name = name;
            Lines.AddRange(lines);
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

        public Boolean IsStatic { get; set; }

        public Boolean IsAbstract { get; set; }

        public Boolean IsVirtual { get; set; }

        public Boolean IsOverride { get; set; }

        public Boolean IsAsync { get; set; }

        public String Type { get; set; }

        public String Name { get; set; }

        public String GenericType { get; set; }

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

        private List<String> m_whereConstraints;
        private List<CodeLine> m_lines;

        public List<String> WhereConstraints
        {
            get
            {
                return m_whereConstraints ?? (m_whereConstraints = new List<String>());
            }
            set
            {
                m_whereConstraints = value;
            }
        }

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
