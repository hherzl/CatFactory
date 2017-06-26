using System.Collections.Generic;
using CatFactory.Diagnostics;

namespace CatFactory.OOP
{
    public interface IClassDefinitionValidator : IObjectDefinitionValidator
    {
        IEnumerable<ValidationMessage> Validate(IClassDefinition classDefinition);
    }
}
