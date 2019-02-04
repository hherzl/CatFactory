using System.Collections.Generic;
using System.Diagnostics;
using CatFactory.CodeFactory;

namespace CatFactory.ObjectOrientedProgramming
{
    /// <summary>
    /// Represents a definition for Method in Object Oriented Programming context
    /// </summary>
    [DebuggerDisplay("AccessModifier={AccessModifier}, Type={Type}, Name={Name}, Parameters={Parameters.Count}")]
    public class MethodDefinition : IMemberDefinition
    {
        /// <summary>
        /// Initializes a new instance of <see cref="MethodDefinition"/> class
        /// </summary>
        public MethodDefinition()
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="MethodDefinition"/> class
        /// </summary>
        /// <param name="type">Type</param>
        /// <param name="name">Name</param>
        /// <param name="parameters">Parameters</param>
        public MethodDefinition(string type, string name, params ParameterDefinition[] parameters)
        {
            Type = type;
            Name = name;
            Parameters.AddRange(parameters);
        }

        /// <summary>
        /// Initializes a new instance of <see cref="MethodDefinition"/> class
        /// </summary>
        /// <param name="accessModifier">Access modifier</param>
        /// <param name="type">Type</param>
        /// <param name="name">Name</param>
        /// <param name="parameters">Parameters</param>
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
        /// Gets or sets the XML documentation comments for current class constructor definition
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
        /// Gets or sets the attributes for current property definition
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
        /// Gets or sets the access modifier for current method definition
        /// </summary>
        public AccessModifier AccessModifier { get; set; }

        /// <summary>
        /// Indicates if current method definition is static
        /// </summary>
        public bool IsStatic { get; set; }

        /// <summary>
        /// Indicates if current method definition is abstract
        /// </summary>
        public bool IsAbstract { get; set; }

        /// <summary>
        /// Indicates if current method definition is virtual
        /// </summary>
        public bool IsVirtual { get; set; }

        /// <summary>
        /// Indicates if current method definition is override
        /// </summary>
        public bool IsOverride { get; set; }

        /// <summary>
        /// Indicates if current method definition is async
        /// </summary>
        public bool IsAsync { get; set; }

        /// <summary>
        /// Gets or sets the type for current method definition
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the name for current method definition
        /// </summary>
        public string Name { get; set; }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<GenericTypeDefinition> m_genericTypes;

        /// <summary>
        /// Gets or sets the generic types for current method definition
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
        /// Indicates if current method definition is extension
        /// </summary>
        public bool IsExtension { get; set; }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<ParameterDefinition> m_parameters;

        /// <summary>
        /// Gets or sets the parameters for current method definition
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
        /// Gets or sets the lines for method body
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
