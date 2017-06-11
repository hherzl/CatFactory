using System;

namespace CatFactory.Mapping
{
    public class PrimaryKey : Constraint, IConstraint
    {
        public PrimaryKey()
        {
        }

        public PrimaryKey(params String[] key)
            : base(key)
        {
        }
    }
}
