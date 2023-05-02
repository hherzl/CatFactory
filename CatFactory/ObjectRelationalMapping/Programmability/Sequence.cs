using System.Diagnostics;
using System.Dynamic;
using System.Xml.Serialization;

namespace CatFactory.ObjectRelationalMapping.Programmability
{
    /// <summary>
    /// Represents the model for sequences
    /// </summary>
    public class Sequence : DbObject
    {
        #region [ Fields ]

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private dynamic m_importBag;

        #endregion

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
        /// <param name="serverName">Server name</param>
        /// <param name="databaseName">Database name</param>
        /// <param name="schema">Schema</param>
        /// <param name="name">Name</param>
        public Sequence(string serverName, string databaseName, string schema, string name)
            : base(serverName, databaseName, schema, name)
        {
        }

        #endregion

        #region [ Properties ]

        /// <summary>
        /// Gets or sets the extension data for import
        /// </summary>
        [XmlIgnore]
        public dynamic ImportBag
        {
            get => m_importBag ??= new ExpandoObject();
            set => m_importBag = value;
        }

        /// <summary>
        /// Indicates if current sequence is cycling
        /// </summary>
        public bool? IsCycling { get; set; }

        /// <summary>
        /// Indicates if current sequence is cached
        /// </summary>
        public bool? IsCached { get; set; }

        #endregion
    }
}
