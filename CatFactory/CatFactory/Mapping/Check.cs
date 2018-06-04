namespace CatFactory.Mapping
{
    /// <summary>
    /// Represents a check constraint
    /// </summary>
    public class Check : Constraint
    {
        /// <summary>
        /// Initializes a new instance of <see cref="CatFactory.Mapping.Check"/> class
        /// </summary>
        public Check()
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="CatFactory.Mapping.Check"/> class
        /// </summary>
        /// <param name="key">Key for constraint</param>
        public Check(params string[] key)
            : base(key)
        {
        }
    }
}
