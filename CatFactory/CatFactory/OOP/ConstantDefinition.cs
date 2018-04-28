using System.Diagnostics;

namespace CatFactory.OOP
{
    [DebuggerDisplay("IsReadOnly = {IsReadOnly}, AccessModifier={AccessModifier}, Type={Type}, Name={Name}")]
    public class ConstantDefinition
    {
        public ConstantDefinition()
        {
        }

        public ConstantDefinition(AccessModifier accessModifier, string type, string name, object value)
        {
            AccessModifier = accessModifier;
            Type = type;
            Name = name;
            Value = value;
        }

        public ConstantDefinition(string type, string name, object value)
        {
            Type = type;
            Name = name;
            Value = value;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Documentation m_documentation;

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

        public AccessModifier AccessModifier { get; set; }

        public string Type { get; set; }

        public string Name { get; set; }

        public object Value { get; set; }
    }
}
