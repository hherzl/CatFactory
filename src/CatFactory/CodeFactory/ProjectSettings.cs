using System.Collections.Generic;
using CatFactory.Diagnostics;

namespace CatFactory.CodeFactory
{
    public class ProjectSettings : IProjectSettings
    {
        public virtual ValidationResult Validate()
            => null;
    }
}
