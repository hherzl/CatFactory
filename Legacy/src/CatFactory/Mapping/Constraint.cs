using System.Collections.Generic;
using System.Diagnostics;

namespace CatFactory.Mapping
{
    [DebuggerDisplay("ConstraintName={ConstraintName}, Key={string.Join(\",\", Key)}")]
    public class Constraint : IConstraint
    {
        public Constraint()
        {
        }

        public Constraint(params string[] key)
        {
            Key.AddRange(key);
        }

        public string ConstraintName { get; set; }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<string> m_key;

        public List<string> Key
        {
            get
            {
                return m_key ?? (m_key = new List<string>());
            }
            set
            {
                m_key = value;
            }
        }
    }
}
