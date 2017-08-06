using System;

namespace CatFactory.Mapping
{
    public class Check : Constraint
    {
        public Check()
        {
        }

        public Check(params String[] key)
            : base(key)
        {
        }
    }
}
