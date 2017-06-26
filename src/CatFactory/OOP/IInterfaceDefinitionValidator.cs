using System.Collections.Generic;
using CatFactory.Diagnostics;

namespace CatFactory.OOP
{
    public interface IInterfaceDefinitionValidator : IObjectDefinitionValidator
    {
        IEnumerable<ValidationMessage> Validate(IInterfaceDefinition objectDefinition);
    }
}
