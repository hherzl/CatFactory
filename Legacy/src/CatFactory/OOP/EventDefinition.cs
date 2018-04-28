using System.Diagnostics;

namespace CatFactory.OOP
{
    [DebuggerDisplay("AccessModifier={AccessModifier}, Type={Type}, Name={Name}")]
    public class EventDefinition : IMemberDefinition
    {
        public EventDefinition()
        {
        }

        public EventDefinition(string type, string name)
        {
            Type = type;
            Name = name;
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
    }
}
