using System;
using System.Collections.Generic;

namespace CatFactory.Mapping
{
    public class PrimaryKey
    {
        public PrimaryKey()
        {

        }

        public PrimaryKey(String[] key)
        {
            Key = new List<String>(key);
        }

        public List<String> Key { get; set; }
    }
}
