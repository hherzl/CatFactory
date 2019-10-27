namespace CatFactory.ObjectRelationalMapping.Programmability
{
    /// <summary>
    /// Represents the model for <see cref="short"/> sequence
    /// </summary>
    public class Int16Sequence : Sequence
    {
        #region [ Constructors ]

        /// <summary>
        /// Initializes a new instance of <see cref="Int16Sequence"/> class
        /// </summary>
        public Int16Sequence()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="Int16Sequence"/> class
        /// </summary>
        /// <param name="schema">Schema</param>
        /// <param name="name">Name</param>
        public Int16Sequence(string schema, string name)
            : base(schema, name)
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="Int16Sequence"/> class
        /// </summary>
        /// <param name="serverName">Server name</param>
        /// <param name="databaseName">Database name</param>
        /// <param name="schema">Schema</param>
        /// <param name="name">Name</param>
        public Int16Sequence(string serverName, string databaseName, string schema, string name)
            : base(serverName, databaseName, schema, name)
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
