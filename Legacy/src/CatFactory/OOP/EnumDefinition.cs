using System.Collections.Generic;
using System.Diagnostics;

namespace CatFactory.OOP
{
    [DebuggerDisplay("AccessModifier={AccessModifier}, Namespace={Namespace}, Name={Name}")]
    public class EnumDefinition : ObjectDefinition, IEnumDefinition
    {
        public EnumDefinition()
        {
        }

        public EnumDefinition(string name, params MetadataAttribute[] attribs)
        {
            Name = name;
            Attributes.AddRange(attribs);
        }

        public EnumDefinition(AccessModifier accessModifier, string name, params MetadataAttribute[] attribs)
        {
            AccessModifier = accessModifier;
            Name = name;
            Attributes.AddRange(attribs);
        }

        public string BaseType { get; set; }

        public override bool HasInheritance
            => !string.IsNullOrEmpty(BaseType);

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<INameValue> m_sets;

        public List<INameValue> Sets
        {
            get
            {
                return m_sets ?? (m_sets = new List<INameValue>());
            }
            set
            {
                m_sets = value;
            }
        }
    }
}
