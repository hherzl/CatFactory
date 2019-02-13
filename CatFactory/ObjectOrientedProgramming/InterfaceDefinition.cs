using System.Collections.Generic;
using System.Diagnostics;

namespace CatFactory.ObjectOrientedProgramming
{
    /// <summary>
    /// Represents a definition for Interface in Object Oriented Programming context
    /// </summary>
    [DebuggerDisplay("AccessModifier={AccessModifier}, Namespace={Namespace}, Name={Name}")]
    public class InterfaceDefinition : ObjectDefinition, IInterfaceDefinition
    {
        /// <summary>
        /// Initializes a new instance of <see cref="InterfaceDefinition"/> class
        /// </summary>
        public InterfaceDefinition()
            : base()
        {
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<GenericTypeDefinition> m_genericTypes;

        /// <summary>
        /// Gets or sets the generic types for current object definition
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

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<string> m_implements;

        /// <summary>
        /// Gets or sets the implements list (Interfaces) for current class definition
        /// </summary>
        public List<string> Implements
        {
            get
            {
                return m_implements ?? (m_implements = new List<string>());
            }
            set
            {
                m_implements = value;
            }
        }

        /// <summary>
        /// Indicates if current object definition has inheritance (Implements)
        /// </summary>
        public override bool HasInheritance
            => Implements.Count > 0;
    }
}
