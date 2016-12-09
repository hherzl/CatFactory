using System;

namespace CatFactory.Mapping
{
    public class Identity
    {
        public Identity()
        {

        }

        public Identity(String name, Int32 seed, Int32 increment)
        {
            Name = name;
            Seed = seed;
            Increment = increment;
        }

        public String Name { get; set; }

        public Int32 Seed { get; set; }

        public Int32 Increment { get; set; }
    }
}
