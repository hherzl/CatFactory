using System.Collections.Generic;
using System.Diagnostics;
using CatFactory.CodeFactory;

namespace CatFactory.OOP
{
    [DebuggerDisplay("AccessModifier={AccessModifier}, ParentInvoke={ParentInvoke}")]
    public class ClassConstructorDefinition
    {
        public ClassConstructorDefinition()
        {
        }

        public ClassConstructorDefinition(params ParameterDefinition[] parameters)
        {
            Parameters.AddRange(parameters);
        }

        public ClassConstructorDefinition(AccessModifier accessModifier, params ParameterDefinition[] parameters)
        {
            AccessModifier = accessModifier;
            Parameters.AddRange(parameters);
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

        public AccessModifier AccessModifier { get; set; }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
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

        public string Invocation { get; set; }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<ILine> m_lines;

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
