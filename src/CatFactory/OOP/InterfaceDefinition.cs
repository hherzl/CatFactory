using System;

namespace CatFactory.OOP
{
    public class InterfaceDefinition : ObjectDefinition, IInterfaceDefinition
    {
        public Boolean IsPartial { get; set; }
    }
}
