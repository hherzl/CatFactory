using System.Collections.Generic;
using System.Diagnostics;

namespace CatFactory.OOP
{
    /// <summary>
    /// 
    /// </summary>
    [DebuggerDisplay("AccessModifier={AccessModifier}, Namespace={Namespace}, Name={Name}")]
    public class EnumDefinition : ObjectDefinition, IEnumDefinition
    {
        /// <summary>
        /// 
        /// </summary>
        public EnumDefinition()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="attribs"></param>
        public EnumDefinition(string name, params MetadataAttribute[] attribs)
        {
            Name = name;
            Attributes.AddRange(attribs);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="accessModifier"></param>
        /// <param name="name"></param>
        /// <param name="attribs"></param>
        public EnumDefinition(AccessModifier accessModifier, string name, params MetadataAttribute[] attribs)
        {
            AccessModifier = accessModifier;
            Name = name;
            Attributes.AddRange(attribs);
        }

        /// <summary>
        /// 
        /// </summary>
        public string BaseType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public override bool HasInheritance
            => !string.IsNullOrEmpty(BaseType);

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<INameValue> m_sets;

        /// <summary>
        /// 
        /// </summary>
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
