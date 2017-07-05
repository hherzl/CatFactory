using System;
using System.Diagnostics;

namespace CatFactory.OOP
{
    [DebuggerDisplay("Name={Name}, Value={Value}")]
    public class MetadataAttributeSet : INameValue
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
