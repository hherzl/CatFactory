using System;

namespace CatFactory.Mapping
{
    public class Unique : Constraint, IConstraint
    {
        public Unique()
        {
        }

        public Unique(params String[] key)
            : base(key)
        {
        }
    }
}
