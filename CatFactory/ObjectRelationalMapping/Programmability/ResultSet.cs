namespace CatFactory.ObjectRelationalMapping.Programmability
{
    /// <summary>
    /// Represents the result set for readable object
    /// </summary>
    public class ResultSet
    {
        /// <summary>
        /// Initializes a new instance of <see cref="ResultSet"/> class
        /// </summary>
        public ResultSet()
        {
        }

        /// <summary>
        /// Gets or sets the name
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Gets or sets the type
        /// </summary>
        string Type { get; set; }

        /// <summary>
        /// Gets or sets the length
        /// </summary>
        int Length { get; set; }

        /// <summary>
        /// Gets or sets the precision
        /// </summary>
        short Prec { get; set; }

        /// <summary>
        /// Gets or sets the scale
        /// </summary>
        short Scale { get; set; }

        /// <summary>
        /// Gets or sets if result set allows null value
        /// </summary>
        public bool Nullable { get; set; }

        /// <summary>
        /// Gets or sets collation for result name
        /// </summary>
        public string Collation { get; set; }
    }
}
