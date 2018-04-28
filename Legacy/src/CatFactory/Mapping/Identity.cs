using System.Diagnostics;

namespace CatFactory.Mapping
{
    [DebuggerDisplay("Name={Name}, Seed={Seed}, Increment={Increment}")]
    public class Identity
    {
        public Identity()
        {
        }

        public Identity(string name, int seed, int increment)
        {
            Name = name;
            Seed = seed;
            Increment = increment;
        }

        public string Name { get; set; }

        public int Seed { get; set; }

        public int Increment { get; set; }
    }
}
