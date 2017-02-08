using System.Collections.Generic;
using CatFactory.Diagnostics;

namespace CatFactory.Mapping
{
    public interface IDatabaseValidator
    {
        IEnumerable<ValidationMessage> Validate(Database database);
    }
}
