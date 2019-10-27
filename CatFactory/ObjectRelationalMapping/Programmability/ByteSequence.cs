namespace CatFactory.ObjectRelationalMapping.Programmability
{
    /// <summary>
    /// Represents the model for <see cref="byte"/> sequence
    /// </summary>
    public class ByteSequence : Sequence
    {
        #region [ Constructors ]

        /// <summary>
        /// Initializes a new instance of <see cref="ByteSequence"/> class
        /// </summary>
        public ByteSequence()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="ByteSequence"/> class
        /// </summary>
        /// <param name="schema">Schema</param>
        /// <param name="name">Name</param>
        public ByteSequence(string schema, string name)
            : base(schema, name)
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="ByteSequence"/> class
        /// </summary>
        /// <param name="serverName">Server name</param>
        /// <param name="databaseName">Database name</param>
        /// <param name="schema">Schema</param>
        /// <param name="name">Name</param>
        public ByteSequence(string serverName, string databaseName, string schema, string name)
            : base(serverName, databaseName, schema, name)
        {
        }

        #endregion

        #region [ Properties ]

        /// <summary>
        /// Gets or sets the start value for current sequence
        /// </summary>
        public byte StartValue { get; set; }

        /// <summary>
        /// Gets or sets the increment for current sequence
        /// </summary>
        public byte Increment { get; set; }

        /// <summary>
        /// Gets or sets the minimum value for current sequence
        /// </summary>
        public byte MinimumValue { get; set; }

        /// <summary>
        /// Gets or sets the maximum value for current sequence
        /// </summary>
        public byte MaximumValue { get; set; }

        /// <summary>
        /// Gets or sets the current value for current sequence
        /// </summary>
        public byte CurrentValue { get; set; }

        #endregion
    }
}
