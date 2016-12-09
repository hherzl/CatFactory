using System;

namespace CatFactory.OOP
{
    public class ParameterDefinition
    {
        public ParameterDefinition(String type, String name)
        {
            Type = type;
            Name = name;
        }

        public String Documentation { get; set; }

        public String Type { get; set; }

        public String Name { get; set; }
    }
}
