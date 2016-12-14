using System;
using System.Collections.Generic;

namespace CatFactory.Mapping
{
    public class Unique : IConstraint
    {
        public Unique()
        {
        }

        public Unique(String[] key)
        {
            Key = new List<String>(key);
        }

        public String ConstraintName { get; set; }

        public List<String> Key { get; set; }
    }
}
