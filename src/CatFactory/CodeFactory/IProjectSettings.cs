using System.Collections.Generic;
using CatFactory.Diagnostics;

namespace CatFactory.CodeFactory
{
    public interface IProjectSettings
    {
        IEnumerable<ValidationMessage> Validate();
    }
}
