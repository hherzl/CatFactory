namespace CatFactory.ObjectRelationalMapping
{
    /// <summary>
    /// Represents the model for <see cref="long"/> sequence
    /// </summary>
    public class Int64Sequence : Sequence
    {
        #region [ Constructors ]

        /// <summary>
        /// Initializes a new instance of <see cref="Int64Sequence"/> class
        /// </summary>
        public Int64Sequence()
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="Int64Sequence"/> class
        /// </summary>
        /// <param name="schema">Schema</param>
        /// <param name="name">Name</param>
        public Int64Sequence(string schema, string name)
            : base(schema, name)
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="Int64Sequence"/> class
        /// </summary>
        /// <param name="dataSource">Data source</param>
        /// <param name="catalog">Catalog</param>
        /// <param name="schema">Schema</param>
        /// <param name="name">Name</param>
        public Int64Sequence(string dataSource, string catalog, string schema, string name)
            : base(dataSource, catalog, schema, name)
        {
        }

        #endregion

        #region [ Properties ]

        /// <summary>
        /// Gets or sets the start value for current sequence
        /// </summary>
        public short StartValue { get; set; }

        /// <summary>
        /// Gets or sets the increment for current sequence
        /// </summary>
        public short Increment { get; set; }

        /// <summary>
        /// Gets or sets the minimum value for current sequence
        /// </summary>
        public short MinimumValue { get; set; }

        /// <summary>
        /// Gets or sets the maximum value for current sequence
        /// </summary>
        public short MaximumValue { get; set; }

        /// <summary>
        /// Gets or sets the current value for current sequence
        /// </summary>
        public short CurrentValue { get; set; }

        #endregion
    }
}
