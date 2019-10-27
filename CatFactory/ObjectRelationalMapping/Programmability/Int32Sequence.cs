namespace CatFactory.ObjectRelationalMapping.Programmability
{
    /// <summary>
    /// Represents the model for <see cref="int"/> sequence
    /// </summary>
    public class Int32Sequence : Sequence
    {
        #region [ Constructors ]

        /// <summary>
        /// Initializes a new instance of <see cref="Int32Sequence"/> class
        /// </summary>
        public Int32Sequence()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="Int32Sequence"/> class
        /// </summary>
        /// <param name="schema">Schema</param>
        /// <param name="name">Name</param>
        public Int32Sequence(string schema, string name)
            : base(schema, name)
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="Int32Sequence"/> class
        /// </summary>
        /// <param name="serverName">Server name</param>
        /// <param name="databaseName">Database name</param>
        /// <param name="schema">Schema</param>
        /// <param name="name">Name</param>
        public Int32Sequence(string serverName, string databaseName, string schema, string name)
            : base(serverName, databaseName, schema, name)
        {
        }

        #endregion

        #region [ Properties ]

        /// <summary>
        /// Gets or sets the start value for current sequence
        /// </summary>
        public int StartValue { get; set; }

        /// <summary>
        /// Gets or sets the increment for current sequence
        /// </summary>
        public int Increment { get; set; }

        /// <summary>
        /// Gets or sets the minimum value for current sequence
        /// </summary>
        public int MinimumValue { get; set; }

        /// <summary>
        /// Gets or sets the maximum value for current sequence
        /// </summary>
        public int MaximumValue { get; set; }

        /// <summary>
        /// Gets or sets the current value for current sequence
        /// </summary>
        public int CurrentValue { get; set; }

        #endregion
    }
}
