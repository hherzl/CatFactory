using System;
using System.Collections.Generic;

namespace CatFactory.Mapping
{
    public class ForeignKey : IConstraint
    {
        public ForeignKey()
        {
        }

        public ForeignKey(params String[] key)
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

        public String References { get; set; }
    }
}
