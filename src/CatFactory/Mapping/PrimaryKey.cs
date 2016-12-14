using System;
using System.Collections.Generic;

namespace CatFactory.Mapping
{
    public class PrimaryKey : IConstraint
    {
        public PrimaryKey()
        {
        }

        public PrimaryKey(String[] key)
        {
            Key = new List<String>(key);
        }

        public String ConstraintName { get; set; }

        public List<String> Key { get; set; }
    }
}
