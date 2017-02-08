using System;

namespace CatFactory.OOP
{
    public class NameValue : INameValue
    {
        public NameValue()
        {
        }

        public NameValue(String name, String value)
        {
            Name = name;
            Value = value;
        }

        public String Name { get; set; }

        public String Value { get; set; }
    }
}
