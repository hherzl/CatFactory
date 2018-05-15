namespace CatFactory.Mapping
{
    /// <summary>
    /// Represents an unique constraint
    /// </summary>
    public class Unique : Constraint
    {
        /// <summary>
        /// Initializes a new instance of <see cref="CatFactory.Mapping.Unique"/> class
        /// </summary>
        public Unique()
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="CatFactory.Mapping.Unique"/> class
        /// </summary>
        /// <param name="key">Key for constraint</param>
        public Unique(params string[] key)
            : base(key)
        {
        }
    }
}
