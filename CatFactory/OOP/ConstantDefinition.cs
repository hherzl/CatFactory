using System.Diagnostics;

namespace CatFactory.OOP
{
    /// <summary>
    /// 
    /// </summary>
    [DebuggerDisplay("IsReadOnly = {IsReadOnly}, AccessModifier={AccessModifier}, Type={Type}, Name={Name}")]
    public class ConstantDefinition
    {
        /// <summary>
        /// 
        /// </summary>
        public ConstantDefinition()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="accessModifier"></param>
        /// <param name="type"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        public ConstantDefinition(AccessModifier accessModifier, string type, string name, object value)
        {
            AccessModifier = accessModifier;
            Type = type;
            Name = name;
            Value = value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        public ConstantDefinition(string type, string name, object value)
        {
            Type = type;
            Name = name;
            Value = value;
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

        /// <summary>
        /// 
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public object Value { get; set; }
    }
}
