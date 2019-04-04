namespace CatFactory.ObjectRelationalMapping
{
    /// <summary>
    /// Represents the model for sequences
    /// </summary>
    public class Sequence : DbObject
    {
        #region [ Constructors ]

        /// <summary>
        /// Initializes a new instance of <see cref="Sequence"/> class
        /// </summary>
        public Sequence()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="Sequence"/> class
        /// </summary>
        /// <param name="schema">Schema</param>
        /// <param name="name">Name</param>
        public Sequence(string schema, string name)
            : base(schema, name)
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="Sequence"/> class
        /// </summary>
        /// <param name="dataSource">Data source</param>
        /// <param name="catalog">Catalog</param>
        /// <param name="schema">Schema</param>
        /// <param name="name">Name</param>
        public Sequence(string dataSource, string catalog, string schema, string name)
            : base(dataSource, catalog, schema, name)
        {
        }

        #endregion

        #region [ Properties ]

        /// <summary>
        /// Indicates if current sequence is cycling
        /// </summary>
        public bool IsCycling { get; set; }

        /// <summary>
        /// Indicates if current sequence is cahed
        /// </summary>
        public bool IsCached { get; set; }

        #endregion
    }
}
