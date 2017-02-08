using System;

namespace CatFactory.OOP
{
    public interface IMemberDefinition
    {
        AccessModifier AccessModifier { get; set; }

        String Type { get; set; }

        String Name { get; set; }
    }
}
