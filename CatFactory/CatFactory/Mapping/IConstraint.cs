using System.Collections.Generic;

namespace CatFactory.Mapping
{
    public interface IConstraint
    {
        string ConstraintName { get; set; }

        List<string> Key { get; set; }
    }
}
