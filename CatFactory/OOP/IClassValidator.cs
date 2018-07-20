using System.Collections.Generic;
using CatFactory.Diagnostics;

namespace CatFactory.OOP
{
    public interface IClassValidator
    {
        IEnumerable<ValidationMessage> Validate(ClassDefinition classDefinition);
    }
}
