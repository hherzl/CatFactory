using System;
using System.Collections.Generic;

namespace CatFactory.Mapping
{
    public interface IConstraint
    {
        String ConstraintName { get; set; }

        List<String> Key { get; set; }
    }
}
