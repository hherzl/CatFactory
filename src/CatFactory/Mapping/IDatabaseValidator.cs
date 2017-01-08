using System.Collections.Generic;

namespace CatFactory.Mapping
{
    public interface IDatabaseValidator
    {
        IEnumerable<ValidationMessage> Validate(Database database);
    }
}
