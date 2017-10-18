using System.Collections.Generic;
using System.Diagnostics;

namespace CatFactory.OOP
{
    [DebuggerDisplay("AccessModifier={AccessModifier}, Namespace={Namespace}, Name={Name}")]
    public class InterfaceDefinition : ObjectDefinition, IInterfaceDefinition
    {
        public InterfaceDefinition()
            : base()
        {
        }

        public string GenericType { get; set; }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<string> m_whereConstraints;

        public List<string> WhereConstraints
        {
            get
            {
                return m_whereConstraints ?? (m_whereConstraints = new List<string>());
            }
            set
            {
                m_whereConstraints = value;
            }
        }
    }
}
