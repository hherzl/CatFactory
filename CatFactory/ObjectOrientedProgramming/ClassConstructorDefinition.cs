using System.Collections.Generic;
using System.Diagnostics;
using CatFactory.CodeFactory;

namespace CatFactory.ObjectOrientedProgramming
{
    /// <summary>
    /// 
    /// </summary>
    [DebuggerDisplay("AccessModifier={AccessModifier}, ParentInvoke={ParentInvoke}")]
    public class ClassConstructorDefinition
    {
        /// <summary>
        /// 
        /// </summary>
        public ClassConstructorDefinition()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="parameters"></param>
        public ClassConstructorDefinition(params ParameterDefinition[] parameters)
        {
            Parameters.AddRange(parameters);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="accessModifier"></param>
        /// <param name="parameters"></param>
        public ClassConstructorDefinition(AccessModifier accessModifier, params ParameterDefinition[] parameters)
        {
            AccessModifier = accessModifier;
            Parameters.AddRange(parameters);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Documentation m_documentation;

        /// <summary>
        /// 
        /// </summary>
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

        /// <summary>
        /// 
        /// </summary>
        public AccessModifier AccessModifier { get; set; }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<ParameterDefinition> m_parameters;

        /// <summary>
        /// 
        /// </summary>
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

        /// <summary>
        /// 
        /// </summary>
        public string Invocation { get; set; }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<ILine> m_lines;

        /// <summary>
        /// 
        /// </summary>
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
