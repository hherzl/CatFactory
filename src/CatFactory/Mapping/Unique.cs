using System;
using System.Collections.Generic;

namespace CatFactory.Mapping
{
    public class Unique
    {
        public Unique()
        {
        }

        public Unique(String[] key)
        {
            Key = new List<String>(key);
        }

        public List<String> Key { get; set; }
    }
}
