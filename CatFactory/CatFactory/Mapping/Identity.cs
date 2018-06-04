using System.Diagnostics;

namespace CatFactory.Mapping
{
    /// <summary>
    /// Represents an identity (auto increment) for table and view
    /// </summary>
    [DebuggerDisplay("Name={Name}, Seed={Seed}, Increment={Increment}")]
    public class Identity
    {
        /// <summary>
        /// Initializes a new instance of <see cref="CatFactory.Mapping.Identity"/> class
        /// </summary>
        public Identity()
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="CatFactory.Mapping.Identity"/> class
        /// </summary>
        /// <param name="name">Column's name</param>
        /// <param name="seed">Seed</param>
        /// <param name="increment">Increment</param>
        public Identity(string name, int seed, int increment)
        {
            Name = name;
            Seed = seed;
            Increment = increment;
        }

        /// <summary>
        /// Gets or sets the column's name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the seed
        /// </summary>
        public int Seed { get; set; }

        /// <summary>
        /// Gets or sets the increment
        /// </summary>
        public int Increment { get; set; }
    }
}
