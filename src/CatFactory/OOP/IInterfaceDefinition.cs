using System;

namespace CatFactory.OOP
{
    public interface IInterfaceDefinition : IObjectDefinition
    {
        Boolean IsPartial { get; set; }
    }
}
