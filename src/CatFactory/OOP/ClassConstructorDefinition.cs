using System;
using System.Collections.Generic;
using CatFactory.CodeFactory;

namespace CatFactory.OOP
{
    public class ClassConstructorDefinition
    {
        public ClassConstructorDefinition()
        {

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

        public String ParentInvoke { get; set; }

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
