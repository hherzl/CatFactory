using System;
using System.Collections.Generic;

namespace CatFactory.OOP
{
    public class MetadataAttribute
    {
        public MetadataAttribute(String name)
        {
            Name = name;
        }

        public String Name { get; set; }

        public List<String> Arguments { get; set; }

        public List<String> Sets { get; set; }

        public Boolean HasArguments
        {
            get
            {
                return Arguments != null && Arguments.Count > 0;
            }
        }

        public Boolean HasSets
        {
            get
            {
                return Sets != null && Sets.Count > 0;
            }
        }

        public Boolean HasMembers
        {
            get
            {
                return HasArguments || HasSets;
            }
        }
    }
}
