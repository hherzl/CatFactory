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
            Key = new List<String>(key);
        }

        public String ConstraintName { get; set; }

        public List<String> Key { get; set; }

        public String References { get; set; }
    }
}
