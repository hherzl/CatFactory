﻿using System.Collections.Generic;
using System.Diagnostics;
using CatFactory.CodeFactory;

namespace CatFactory.ObjectOrientedProgramming
{
    /// <summary>
    /// Represents a definition for Constructor in Object Oriented Programming context
    /// </summary>
    [DebuggerDisplay("AccessModifier={AccessModifier}, ParentInvoke={ParentInvoke}")]
    public class ClassConstructorDefinition
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Documentation m_documentation;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<ParameterDefinition> m_parameters;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<ILine> m_lines;

        /// <summary>
        /// Initializes a new instance of <see cref="ClassConstructorDefinition"/> class
        /// </summary>
        public ClassConstructorDefinition()
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="ClassConstructorDefinition"/> class
        /// </summary>
        /// <param name="parameters">Parameters</param>
        public ClassConstructorDefinition(params ParameterDefinition[] parameters)
        {
            Parameters.AddRange(parameters);
        }

        /// <summary>
        /// Initializes a new instance of <see cref="ClassConstructorDefinition"/> class
        /// </summary>
        /// <param name="accessModifier">Access modifier</param>
        /// <param name="parameters">Parameters</param>
        public ClassConstructorDefinition(AccessModifier accessModifier, params ParameterDefinition[] parameters)
        {
            AccessModifier = accessModifier;
            Parameters.AddRange(parameters);
        }

        /// <summary>
        /// Gets or sets the XML documentation comments for current class constructor definition
        /// </summary>
        public Documentation Documentation
        {
            get => m_documentation ??= new Documentation();
            set => m_documentation = value;
        }

        /// <summary>
        /// Gets or sets the access modifier for current class constructor definition
        /// </summary>
        public AccessModifier AccessModifier { get; set; }

        /// <summary>
        /// Gets or sets the parameters for current class constructor definition
        /// </summary>
        public List<ParameterDefinition> Parameters
        {
            get => m_parameters ??= new List<ParameterDefinition>();
            set => m_parameters = value;
        }

        /// <summary>
        /// Gets or sets the invocation (base) for current class constructor definition
        /// </summary>
        public string Invocation { get; set; }

        /// <summary>
        /// Gets or sets the code lines (method body) for current class constructor definition
        /// </summary>
        public List<ILine> Lines
        {
            get => m_lines ??= new List<ILine>();
            set => m_lines = value;
        }
    }
}
