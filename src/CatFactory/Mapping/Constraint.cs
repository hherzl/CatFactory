using System;
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

        public Constraint(params String[] key)
        {
            Key.AddRange(key);
        }

        public String ConstraintName { get; set; }

        private List<String> m_key;

        public List<String> Key
        {
            get
            {
                return m_key ?? (m_key = new List<String>());
            }
            set
            {
                m_key = value;
            }
        }
    }
}
