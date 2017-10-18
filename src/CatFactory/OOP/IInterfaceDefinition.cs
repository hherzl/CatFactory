using System.Collections.Generic;

namespace CatFactory.OOP
{
    public interface IInterfaceDefinition : IObjectDefinition
    {
        string GenericType { get; set; }

        List<string> WhereConstraints { get; set; }
    }
}
