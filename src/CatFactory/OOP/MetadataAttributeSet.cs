using System;

namespace CatFactory.OOP
{
    public class MetadataAttributeSet
    {
        public MetadataAttributeSet()
        {
        }

        public MetadataAttributeSet(String name, String value)
        {
            Name = name;
            Value = value;
        }

        public String Name { get; set; }

        public String Value { get; set; }
    }
}
