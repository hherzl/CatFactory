using System;

namespace CatFactory.OOP
{
    public class EventDefinition
    {
        public EventDefinition()
        {
        }

        public EventDefinition(String type, String name)
        {
            Type = type;
            Name = name;
        }

        public AccessModifier AccessModifier { get; set; }

        public String Type { get; set; }

        public String Name { get; set; }
    }
}
