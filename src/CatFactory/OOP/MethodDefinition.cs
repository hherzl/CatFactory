using System;
using System.Collections.Generic;
using System.Diagnostics;
using CatFactory.CodeFactory;

namespace CatFactory.OOP
{
    [DebuggerDisplay("AccessModifier={AccessModifier}, Type={Type}, Name={Name}, Parameters={Parameters.Count}")]
    public class MethodDefinition : IMemberDefinition
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

        public MethodDefinition(AccessModifier accessModifier, String type, String name, params ParameterDefinition[] parameters)
        {
            AccessModifier = accessModifier;
            Type = type;
            Name = name;
            Parameters.AddRange(parameters);
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

        public Boolean IsExtension { get; set; }

        private List<ParameterDefinition> m_parameters;
        private List<String> m_whereConstraints;
        private List<ILine> m_lines;

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

        public List<ILine> Lines
        {
            get
            {
                return m_lines ?? (m_lines = new List<ILine>());
            }
            set
            {
                m_lines = value;
            }
        }
    }
}
