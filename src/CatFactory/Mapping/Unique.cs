using System;

namespace CatFactory.Mapping
{
    public class Unique : Constraint
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
