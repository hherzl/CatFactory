using System.Collections.Generic;
using System.Diagnostics;

namespace CatFactory.ObjectOrientedProgramming
{
    /// <summary>
    /// 
    /// </summary>
    [DebuggerDisplay("AccessModifier={AccessModifier}, Namespace={Namespace}, Name={Name}")]
    public class InterfaceDefinition : ObjectDefinition, IInterfaceDefinition
    {
        /// <summary>
        /// 
        /// </summary>
        public InterfaceDefinition()
            : base()
        {
        }

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

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<string> m_implements;

        /// <summary>
        /// 
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
        /// 
        /// </summary>
        public override bool HasInheritance
            => Implements.Count > 0;
    }
}
