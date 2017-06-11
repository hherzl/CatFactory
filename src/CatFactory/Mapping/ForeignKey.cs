using System;

namespace CatFactory.Mapping
{
    public class ForeignKey : Constraint, IConstraint
    {
        public ForeignKey()
        {
        }

        public ForeignKey(params String[] key)
            : base(key)
        {
        }

        public String References { get; set; }

        public String Child { get; set; }
    }
}
