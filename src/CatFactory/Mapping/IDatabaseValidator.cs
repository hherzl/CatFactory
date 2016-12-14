using System;
using System.Collections.Generic;

namespace CatFactory.Mapping
{
    public interface IDatabaseValidator
    {
        IEnumerable<String> Validate(Database database);
    }
}
