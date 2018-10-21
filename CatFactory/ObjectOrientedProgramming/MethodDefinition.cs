using System.Collections.Generic;
using System.Diagnostics;
using CatFactory.CodeFactory;

namespace CatFactory.ObjectOrientedProgramming
{
    /// <summary>
    /// 
    /// </summary>
    [DebuggerDisplay("AccessModifier={AccessModifier}, Type={Type}, Name={Name}, Parameters={Parameters.Count}")]
    public class MethodDefinition : IMemberDefinition
    {
        /// <summary>
        /// 
        /// </summary>
        public MethodDefinition()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <param name="name"></param>
        /// <param name="parameters"></param>
        public MethodDefinition(string type, string name, params ParameterDefinition[] parameters)
        {
            Type = type;
            Name = name;
            Parameters.AddRange(parameters);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="accessModifier"></param>
        /// <param name="type"></param>
        /// <param name="name"></param>
        /// <param name="parameters"></param>
        public MethodDefinition(AccessModifier accessModifier, string type, string name, params ParameterDefinition[] parameters)
        {
            AccessModifier = accessModifier;
            Type = type;
            Name = name;
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

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<MetadataAttribute> m_attributes;

        /// <summary>
        /// 
        /// </summary>
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

        /// <summary>
        /// 
        /// </summary>
        public AccessModifier AccessModifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool IsStatic { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool IsAbstract { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool IsVirtual { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool IsOverride { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool IsAsync { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<GenericTypeDefinition> m_genericTypes;

        /// <summary>
        /// 
        /// </summary>
        public List<GenericTypeDefinition> GenericTypes
        {
            get
            {
                return m_genericTypes ?? (m_genericTypes = new List<GenericTypeDefinition>());
            }
            set
            {
                m_genericTypes = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool IsExtension { get; set; }

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
