using System;
using System.Collections.Generic;

namespace CatFactory.Mapping
{
    public class ForeignKey
    {
        public ForeignKey()
        {
        }

        public ForeignKey(String[] key)
        {
            Key = new List<String>(key);
        }

        public List<String> Key { get; set; }

        public String References { get; set; }
    }
}
