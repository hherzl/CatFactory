namespace CatFactory.Mapping
{
    /// <summary>
    /// Represents a primary key constraint
    /// </summary>
    public class PrimaryKey : Constraint
    {
        /// <summary>
        /// Initializes a new instance of <see cref="PrimaryKey"/> class
        /// </summary>
        public PrimaryKey()
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="PrimaryKey"/> class
        /// </summary>
        /// <param name="key">Key for constraint</param>
        public PrimaryKey(params string[] key)
            : base(key)
        {
        }
    }
}
