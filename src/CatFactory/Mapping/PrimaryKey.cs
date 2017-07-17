using System;

namespace CatFactory.Mapping
{
    public class PrimaryKey : Constraint
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
