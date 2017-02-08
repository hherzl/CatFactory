using System;
using System.Diagnostics;

namespace CatFactory.OOP
{
    [DebuggerDisplay("IsReadOnly = {IsReadOnly}, AccessModifier={AccessModifier}, Type={Type}, Name={Name}")]
    public class ConstantDefinition
    {
        public ConstantDefinition()
        {
        }

        public ConstantDefinition(AccessModifier accessModifier, String type, String name, String value)
        {
            AccessModifier = accessModifier;
            Type = type;
            Name = name;
            Value = value;
        }

        public ConstantDefinition(String type, String name, String value)
        {
            Type = type;
            Name = name;
            Value = value;
        }

        public AccessModifier AccessModifier { get; set; }

        public String Type { get; set; }

        public String Name { get; set; }

        public String Value { get; set; }
    }
}
