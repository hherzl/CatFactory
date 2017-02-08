using System.Collections.Generic;
using CatFactory.Diagnostics;

namespace CatFactory.OOP
{
    public interface IDefinitionValidator
    {
        IEnumerable<ValidationMessage> Validate();
    }
}
