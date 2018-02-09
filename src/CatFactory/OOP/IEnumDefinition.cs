using System.Collections.Generic;

namespace CatFactory.OOP
{
    public interface IEnumDefinition : IObjectDefinition
    {
        string BaseType { get; set; }

        List<INameValue> Sets { get; set; }
    }
}
