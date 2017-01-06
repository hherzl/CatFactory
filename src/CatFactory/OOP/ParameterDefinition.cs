using System;
using System.Diagnostics;

namespace CatFactory.OOP
{
    [DebuggerDisplay("Type={Type}, Name={Name}")]
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
