using System.Collections.Generic;
using CatFactory.Diagnostics;

namespace CatFactory
{
    public interface IProjectSettings
    {
        IEnumerable<ValidationMessage> Validate();
    }
}
